#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Project Evidence - 单文件项目验证证据生成器

目标：
- 不生成依赖图/调用图/类图/模块图，不替代 Graphify。
- 只生成验证型硬证据：目录树、类型检查、lint、格式化、复杂度、安全、secret、依赖树、依赖漏洞、测试、构建、运行环境、工具版本。
- 位置无关：脚本可以放在任何位置，通过 --root 指定项目根目录；默认使用当前工作目录。
- 文档默认输出到 <root>/docs/evidence。

常用命令：
  python project_evidence_fixed.py doctor
  python project_evidence_fixed.py verify
  python project_evidence_fixed.py full
  python project_evidence_fixed.py install
  python project_evidence_fixed.py install --yes

注意：
- install 默认只列出缺失工具，不会安装；加 --yes 才会安装。
- 本脚本不会修改你的源码；install --yes 可能会修改依赖文件，例如 package.json、lock 文件、Python 虚拟环境等。
"""
from __future__ import annotations

import argparse
import datetime as _dt
import fnmatch
import json
import os
import platform
import re
import shutil
import subprocess
import sys
from dataclasses import dataclass, field
from pathlib import Path
from typing import Dict, Iterable, List, Optional, Sequence, Tuple

VERSION = "0.2.0"

DEFAULT_IGNORES = {
    ".git", ".hg", ".svn",
    ".idea", ".vscode",
    "node_modules", "bower_components",
    "__pycache__", ".pytest_cache", ".mypy_cache", ".ruff_cache", ".tox", ".nox",
    ".venv", "venv", "env",
    "dist", "build", "target", "out", ".next", ".nuxt", ".svelte-kit",
    "coverage", ".coverage", "htmlcov",
    ".turbo", ".cache", ".parcel-cache",
    "vendor",
    "graphify-out",
}

TEXT_FILE_LIMIT_BYTES = 512_000
COMMAND_TIMEOUT = 120
FULL_COMMAND_TIMEOUT = 300
MAX_TREE_ENTRIES = 1800
MAX_OUTPUT_CHARS = 80_000

LANGUAGE_EXTENSIONS: Dict[str, List[str]] = {
    "Python": [".py", ".pyi"],
    "JavaScript": [".js", ".jsx", ".mjs", ".cjs"],
    "TypeScript": [".ts", ".tsx", ".mts", ".cts"],
    "Go": [".go"],
    "Rust": [".rs"],
    "Java": [".java"],
    "Kotlin": [".kt", ".kts"],
    "Scala": [".scala", ".sc"],
    "C#/.NET": [".cs"],
    "C/C++": [".c", ".h", ".cc", ".cpp", ".cxx", ".hpp", ".hh", ".hxx"],
    "Objective-C": [".m", ".mm"],
    "PHP": [".php"],
    "Ruby": [".rb"],
    "Swift": [".swift"],
    "Dart/Flutter": [".dart"],
    "Elixir": [".ex", ".exs"],
    "Erlang": [".erl", ".hrl"],
    "Haskell": [".hs", ".lhs"],
    "Clojure": [".clj", ".cljs", ".cljc", ".edn"],
    "OCaml": [".ml", ".mli"],
    "Zig": [".zig"],
    "Lua": [".lua"],
    "R": [".r", ".R"],
    "Shell": [".sh", ".bash", ".zsh", ".fish"],
    "PowerShell": [".ps1", ".psm1"],
    "SQL": [".sql"],
    "Terraform": [".tf", ".tfvars"],
    "Docker": [".dockerfile"],
    "Vue": [".vue"],
    "Svelte": [".svelte"],
    "Perl": [".pl", ".pm", ".t"],
    "Nim": [".nim"],
    "Crystal": [".cr"],
}

LANGUAGE_MARKERS: Dict[str, List[str]] = {
    "Python": ["pyproject.toml", "requirements.txt", "setup.py", "setup.cfg", "Pipfile", "poetry.lock", "uv.lock", "tox.ini", "mypy.ini", "pytest.ini"],
    "JavaScript": ["package.json", "package-lock.json", "pnpm-lock.yaml", "yarn.lock", "bun.lockb"],
    "TypeScript": ["tsconfig.json", "tsconfig.base.json"],
    "Go": ["go.mod", "go.sum"],
    "Rust": ["Cargo.toml", "Cargo.lock"],
    "Java": ["pom.xml", "build.gradle", "build.gradle.kts", "settings.gradle", "settings.gradle.kts"],
    "Kotlin": ["build.gradle.kts", "settings.gradle.kts"],
    "Scala": ["build.sbt"],
    "C#/.NET": ["*.csproj", "*.sln", "Directory.Build.props", "Directory.Build.targets", "global.json"],
    "C/C++": ["CMakeLists.txt", "Makefile", "configure.ac", "meson.build", "conanfile.txt", "conanfile.py", "vcpkg.json"],
    "PHP": ["composer.json", "composer.lock"],
    "Ruby": ["Gemfile", "Gemfile.lock", "Rakefile"],
    "Swift": ["Package.swift"],
    "Dart/Flutter": ["pubspec.yaml", "pubspec.lock"],
    "Elixir": ["mix.exs", "mix.lock"],
    "Haskell": ["stack.yaml", "cabal.project", "*.cabal"],
    "Clojure": ["deps.edn", "project.clj"],
    "OCaml": ["dune-project", "*.opam"],
    "Zig": ["build.zig"],
    "R": ["DESCRIPTION", "renv.lock"],
    "Terraform": ["*.tf"],
    "Docker": ["Dockerfile", "docker-compose.yml", "compose.yml"],
}

FILE_DESCRIPTIONS: Dict[str, str] = {
    "README.md": "项目说明文档",
    "AGENTS.md": "AI/Agent 工作规则文档",
    "CLAUDE.md": "Claude/AI 工作规则文档",
    "package.json": "Node.js 项目配置、脚本和依赖声明",
    "pnpm-lock.yaml": "pnpm 锁定依赖版本文件",
    "package-lock.json": "npm 锁定依赖版本文件",
    "yarn.lock": "Yarn 锁定依赖版本文件",
    "bun.lockb": "Bun 锁定依赖版本文件",
    "tsconfig.json": "TypeScript 编译配置",
    "vite.config.ts": "Vite 构建配置",
    "vite.config.js": "Vite 构建配置",
    "next.config.js": "Next.js 配置",
    "next.config.mjs": "Next.js 配置",
    "pyproject.toml": "Python 项目配置、构建配置和工具配置",
    "requirements.txt": "Python pip 依赖列表",
    "setup.py": "Python 打包脚本",
    "setup.cfg": "Python 工具/打包配置",
    "poetry.lock": "Poetry 锁定依赖版本文件",
    "uv.lock": "uv 锁定依赖版本文件",
    "pytest.ini": "pytest 测试配置",
    "go.mod": "Go 模块和依赖声明",
    "go.sum": "Go 依赖校验文件",
    "Cargo.toml": "Rust crate 配置和依赖声明",
    "Cargo.lock": "Rust 锁定依赖版本文件",
    "pom.xml": "Maven 项目配置和依赖声明",
    "build.gradle": "Gradle 构建配置",
    "build.gradle.kts": "Gradle Kotlin DSL 构建配置",
    "settings.gradle": "Gradle 多模块配置",
    "settings.gradle.kts": "Gradle Kotlin DSL 多模块配置",
    "Dockerfile": "Docker 镜像构建文件",
    "docker-compose.yml": "Docker Compose 服务编排配置",
    "compose.yml": "Docker Compose 服务编排配置",
    ".env.example": "环境变量示例文件",
    ".gitignore": "Git 忽略规则",
    "Makefile": "make 命令入口和自动化任务",
    "justfile": "just 命令入口和自动化任务",
    "Taskfile.yml": "Taskfile 自动化任务配置",
}

DIR_DESCRIPTIONS: Dict[str, str] = {
    "src": "源代码目录",
    "app": "应用主代码目录",
    "lib": "库代码目录",
    "core": "核心逻辑目录",
    "server": "服务端代码目录",
    "client": "客户端代码目录",
    "frontend": "前端代码目录",
    "backend": "后端代码目录",
    "api": "接口/API 相关目录",
    "routes": "路由目录",
    "controllers": "控制器目录",
    "services": "业务服务目录",
    "models": "模型/实体目录",
    "schemas": "数据结构/校验模型目录",
    "repositories": "数据访问/仓储目录",
    "dao": "数据访问对象目录",
    "db": "数据库相关目录",
    "database": "数据库相关目录",
    "migrations": "数据库迁移目录",
    "tests": "测试目录",
    "test": "测试目录",
    "spec": "测试规格目录",
    "docs": "项目文档目录",
    "scripts": "脚本目录",
    "config": "配置目录",
    "configs": "配置目录",
    "public": "静态公开资源目录",
    "static": "静态资源目录",
    "assets": "资源目录",
    "components": "组件目录",
    "pages": "页面目录",
    "hooks": "前端 hooks 目录",
    "utils": "工具函数目录",
    "helpers": "辅助函数目录",
    "middleware": "中间件目录",
    "cmd": "Go/Rust/CLI 命令入口目录",
    "internal": "内部包目录",
    "pkg": "公共包目录",
    "bin": "可执行脚本或二进制输出目录",
    "dist": "构建输出目录",
    "build": "构建输出目录",
}

ROOT_README = Path("README.md")
OVERVIEW_DIR = Path("00-总览")
QUALITY_DIR = Path("01-质量检查")
SECURITY_DIR = Path("02-安全检查")
DEPENDENCY_DIR = Path("03-依赖分析")

OUTPUT_DIRS = [OVERVIEW_DIR, QUALITY_DIR, SECURITY_DIR, DEPENDENCY_DIR]

OVERVIEW_FILES: Dict[str, Path] = {
    "usage": OVERVIEW_DIR / "使用说明.md",
    "summary": OVERVIEW_DIR / "验证摘要.md",
    "directory_tree": OVERVIEW_DIR / "中文目录树.md",
    "runtime": OVERVIEW_DIR / "运行环境.md",
    "tool_versions": OVERVIEW_DIR / "工具版本.md",
    "project_profile": OVERVIEW_DIR / "项目画像.json",
}

OVERVIEW_NAV = [
    ("usage", "命令示例、阅读顺序、整体导航"),
    ("summary", "本次验证总览"),
    ("directory_tree", "中文目录树和关键文件说明"),
    ("runtime", "运行环境、语言、包管理器、常用命令"),
    ("tool_versions", "工具版本和安装状态"),
    ("project_profile", "项目识别结果，机器可读"),
]

REPORT_SPECS: Dict[str, Tuple[Path, str]] = {
    "类型检查": (QUALITY_DIR / "类型检查.md", "类型检查报告"),
    "代码风格检查": (QUALITY_DIR / "代码风格检查.md", "代码风格检查报告"),
    "格式检查": (QUALITY_DIR / "格式检查.md", "格式检查报告"),
    "复杂度检查": (QUALITY_DIR / "复杂度检查.md", "复杂度检查报告"),
    "测试结果": (QUALITY_DIR / "测试结果.md", "测试结果报告"),
    "构建结果": (QUALITY_DIR / "构建结果.md", "构建/编译报告"),
    "安全扫描": (SECURITY_DIR / "安全扫描.md", "源码安全扫描报告"),
    "敏感信息扫描": (SECURITY_DIR / "敏感信息扫描.md", "敏感信息扫描报告"),
    "依赖树": (DEPENDENCY_DIR / "依赖树.md", "第三方依赖树报告"),
    "依赖漏洞": (DEPENDENCY_DIR / "依赖漏洞.md", "第三方依赖漏洞报告"),
}

REPORT_DESCRIPTIONS: Dict[str, str] = {
    "类型检查": "类型检查结果",
    "代码风格检查": "代码风格检查结果",
    "格式检查": "格式检查结果",
    "复杂度检查": "复杂度检查结果",
    "测试结果": "测试结果",
    "构建结果": "构建/编译结果",
    "安全扫描": "源码安全扫描结果",
    "敏感信息扫描": "Secret/敏感信息扫描结果",
    "依赖树": "第三方依赖树",
    "依赖漏洞": "第三方依赖漏洞",
}

LEGACY_OUTPUT_FILES = [
    Path("directory-tree.md"),
    Path("runtime.md"),
    Path("tool-versions.md"),
    Path("project-profile.json"),
    Path("summary.md"),
    Path("type-check.md"),
    Path("lint.md"),
    Path("format.md"),
    Path("complexity.md"),
    Path("tests.md"),
    Path("build.md"),
    Path("security.md"),
    Path("secrets.md"),
    Path("dependency-tree.md"),
    Path("dependency-vulnerabilities.md"),
]

LEGACY_OUTPUT_DIRS = [
    Path("10-质量检查"),
    Path("20-安全检查"),
    Path("30-依赖分析"),
]

@dataclass
class CommandResult:
    name: str
    command: List[str]
    cwd: Path
    ok: bool
    skipped: bool
    reason: str = ""
    returncode: Optional[int] = None
    stdout: str = ""
    stderr: str = ""
    duration_sec: float = 0.0

@dataclass
class ProjectProfile:
    root: Path
    languages: Dict[str, int] = field(default_factory=dict)
    marker_hits: Dict[str, List[str]] = field(default_factory=dict)
    package_managers: List[str] = field(default_factory=list)
    important_files: List[str] = field(default_factory=list)
    source_file_count: int = 0
    total_file_count: int = 0

    @property
    def primary_languages(self) -> List[str]:
        keys = set(self.languages.keys()) | set(self.marker_hits.keys())
        def score(lang: str) -> Tuple[int, int]:
            return (self.languages.get(lang, 0) + 4 * len(self.marker_hits.get(lang, [])), self.languages.get(lang, 0))
        return [k for k in sorted(keys, key=score, reverse=True) if score(k) > (0, 0)]


def now_iso() -> str:
    return _dt.datetime.now().astimezone().isoformat(timespec="seconds")


def rel(path: Path, root: Path) -> str:
    try:
        return path.relative_to(root).as_posix()
    except ValueError:
        return path.as_posix()


def is_ignored(path: Path, root: Path, extra_ignores: Sequence[str] = ()) -> bool:
    r = rel(path, root)
    parts = r.split("/")
    ignore_set = set(DEFAULT_IGNORES) | set(extra_ignores)
    for item in ignore_set:
        if not item:
            continue
        item = item.strip().replace("\\", "/")
        if item in parts:
            return True
        if r == item or r.startswith(item.rstrip("/") + "/"):
            return True
        if fnmatch.fnmatch(r, item):
            return True
    return False


def walk_project(root: Path, extra_ignores: Sequence[str] = ()) -> Iterable[Path]:
    for current, dirs, files in os.walk(root):
        current_path = Path(current)
        dirs[:] = sorted([d for d in dirs if not is_ignored(current_path / d, root, extra_ignores)])
        for name in sorted(files):
            p = current_path / name
            if not is_ignored(p, root, extra_ignores):
                yield p


def read_text_safe(path: Path, limit: int = TEXT_FILE_LIMIT_BYTES) -> str:
    try:
        if path.stat().st_size > limit:
            return ""
        return path.read_text(encoding="utf-8", errors="replace")
    except Exception:
        return ""


def which(cmd: str) -> Optional[str]:
    return shutil.which(cmd)


def run_command(name: str, command: List[str], cwd: Path, timeout: int = COMMAND_TIMEOUT) -> CommandResult:
    start = _dt.datetime.now()
    if not command or not which(command[0]):
        return CommandResult(name=name, command=command, cwd=cwd, ok=False, skipped=True, reason=f"未找到命令：{command[0] if command else ''}")
    try:
        proc = subprocess.run(
            command,
            cwd=str(cwd),
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
            text=True,
            errors="replace",
            timeout=timeout,
            shell=False,
        )
        end = _dt.datetime.now()
        return CommandResult(
            name=name,
            command=command,
            cwd=cwd,
            ok=(proc.returncode == 0),
            skipped=False,
            returncode=proc.returncode,
            stdout=truncate(proc.stdout),
            stderr=truncate(proc.stderr),
            duration_sec=(end - start).total_seconds(),
        )
    except subprocess.TimeoutExpired as exc:
        end = _dt.datetime.now()
        return CommandResult(
            name=name,
            command=command,
            cwd=cwd,
            ok=False,
            skipped=False,
            reason=f"命令超时：{timeout} 秒",
            stdout=truncate(exc.stdout or ""),
            stderr=truncate(exc.stderr or ""),
            duration_sec=(end - start).total_seconds(),
        )
    except Exception as exc:
        end = _dt.datetime.now()
        return CommandResult(name=name, command=command, cwd=cwd, ok=False, skipped=False, reason=str(exc), duration_sec=(end - start).total_seconds())


def truncate(text: str, limit: int = MAX_OUTPUT_CHARS) -> str:
    if text is None:
        return ""
    if len(text) <= limit:
        return text
    return text[:limit] + f"\n\n[输出过长，已截断，原始长度约 {len(text)} 字符]\n"


def detect_project(root: Path, extra_ignores: Sequence[str] = ()) -> ProjectProfile:
    profile = ProjectProfile(root=root)
    ext_to_lang: Dict[str, str] = {}
    for lang, exts in LANGUAGE_EXTENSIONS.items():
        for ext in exts:
            ext_to_lang[ext] = lang

    for path in walk_project(root, extra_ignores):
        profile.total_file_count += 1
        name = path.name
        suffix = path.suffix
        if name == "Dockerfile":
            lang = "Docker"
        else:
            lang = ext_to_lang.get(suffix)
        if lang:
            profile.languages[lang] = profile.languages.get(lang, 0) + 1
            profile.source_file_count += 1
        if name in FILE_DESCRIPTIONS or name in {"package.json", "pyproject.toml", "go.mod", "Cargo.toml", "pom.xml", "build.gradle", "Dockerfile"}:
            profile.important_files.append(rel(path, root))

    root_files = list(root.iterdir()) if root.exists() else []
    all_relative_files = [rel(p, root) for p in walk_project(root, extra_ignores)]
    for lang, markers in LANGUAGE_MARKERS.items():
        for marker in markers:
            hit = False
            if "*" in marker:
                for item in all_relative_files:
                    if fnmatch.fnmatch(Path(item).name, marker) or fnmatch.fnmatch(item, marker):
                        hit = True
                        profile.marker_hits.setdefault(lang, []).append(item)
            else:
                if (root / marker).exists():
                    hit = True
                    profile.marker_hits.setdefault(lang, []).append(marker)
            _ = hit

    profile.package_managers = detect_package_managers(root)
    profile.important_files = sorted(set(profile.important_files))[:200]
    return profile


def detect_package_managers(root: Path) -> List[str]:
    managers: List[str] = []
    checks = [
        ("pnpm", root / "pnpm-lock.yaml"),
        ("npm", root / "package-lock.json"),
        ("yarn", root / "yarn.lock"),
        ("bun", root / "bun.lockb"),
        ("poetry", root / "poetry.lock"),
        ("uv", root / "uv.lock"),
        ("pip", root / "requirements.txt"),
        ("pip", root / "pyproject.toml"),
        ("go", root / "go.mod"),
        ("cargo", root / "Cargo.toml"),
        ("maven", root / "pom.xml"),
        ("gradle", root / "build.gradle"),
        ("gradle", root / "build.gradle.kts"),
        ("composer", root / "composer.json"),
        ("bundler", root / "Gemfile"),
        ("pub", root / "pubspec.yaml"),
        ("dotnet", next(root.glob("*.csproj"), None) if root.exists() else Path("__missing__")),
    ]
    for name, path in checks:
        if isinstance(path, Path) and path.exists() and name not in managers:
            managers.append(name)
    return managers


def package_json(root: Path) -> Dict[str, object]:
    p = root / "package.json"
    if not p.exists():
        return {}
    try:
        return json.loads(read_text_safe(p) or "{}")
    except Exception:
        return {}


def has_package_script(root: Path, script: str) -> bool:
    data = package_json(root)
    scripts = data.get("scripts", {}) if isinstance(data, dict) else {}
    return isinstance(scripts, dict) and script in scripts


def node_runner(root: Path) -> str:
    if (root / "pnpm-lock.yaml").exists() and which("pnpm"):
        return "pnpm"
    if (root / "yarn.lock").exists() and which("yarn"):
        return "yarn"
    if (root / "bun.lockb").exists() and which("bun"):
        return "bun"
    return "npm"


def node_run_cmd(root: Path, script: str) -> List[str]:
    runner = node_runner(root)
    if runner == "pnpm":
        return ["pnpm", script] if script in {"test", "build", "lint"} else ["pnpm", "run", script]
    if runner == "yarn":
        return ["yarn", script]
    if runner == "bun":
        return ["bun", "run", script]
    return ["npm", "run", script]


def md_command_result(result: CommandResult) -> str:
    cmd = " ".join(result.command)
    status = "跳过" if result.skipped else ("通过" if result.ok else "失败")
    lines = [
        f"## {result.name}",
        "",
        f"- 状态：**{status}**",
        f"- 命令：`{cmd}`",
        f"- 工作目录：`{result.cwd}`",
    ]
    if result.returncode is not None:
        lines.append(f"- 退出码：`{result.returncode}`")
    if result.duration_sec:
        lines.append(f"- 耗时：`{result.duration_sec:.2f}s`")
    if result.reason:
        lines.append(f"- 说明：{result.reason}")
    lines.append("")
    if result.stdout:
        lines.extend(["### stdout", "", "```text", result.stdout.rstrip(), "```", ""])
    if result.stderr:
        lines.extend(["### stderr", "", "```text", result.stderr.rstrip(), "```", ""])
    if not result.stdout and not result.stderr and not result.reason:
        lines.append("无输出。\n")
    return "\n".join(lines)


def write(path: Path, content: str) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(content.rstrip() + "\n", encoding="utf-8")


def relative_link(from_path: Path, to_path: Path) -> str:
    start = str(from_path.parent) if str(from_path.parent) != "." else "."
    return os.path.relpath(str(to_path), start=start).replace("\\", "/")


def cleanup_legacy_outputs(out: Path) -> None:
    for rel_path in LEGACY_OUTPUT_FILES:
        target = out / rel_path
        if target.exists() and target.is_file():
            target.unlink()
    for rel_dir in LEGACY_OUTPUT_DIRS:
        target = out / rel_dir
        if target.exists() and target.is_dir():
            shutil.rmtree(target)


def ensure_output_dirs(out: Path) -> None:
    out.mkdir(parents=True, exist_ok=True)
    for rel_dir in OUTPUT_DIRS:
        (out / rel_dir).mkdir(parents=True, exist_ok=True)


def output_ignore_patterns(root: Path, out: Path) -> List[str]:
    try:
        rel_out = out.relative_to(root).as_posix()
    except ValueError:
        return []
    if not rel_out or rel_out == ".":
        return []
    return [rel_out]


def build_tree_ignores(root: Path, out: Path, extra_ignores: Sequence[str]) -> List[str]:
    return list(extra_ignores) + output_ignore_patterns(root, out)


def navigation_entries(report_names: Sequence[str]) -> List[Tuple[str, Path, str, str]]:
    entries: List[Tuple[str, Path, str, str]] = []
    for key, description in OVERVIEW_NAV:
        path = OVERVIEW_FILES[key]
        entries.append((path.parent.name, path, path.stem, description))
    for report_name in report_names:
        if report_name not in REPORT_SPECS:
            continue
        path, _ = REPORT_SPECS[report_name]
        entries.append((path.parent.name, path, path.stem, REPORT_DESCRIPTIONS[report_name]))
    return entries


def joined_links(base_path: Path, report_names: Sequence[str]) -> str:
    links = [f"[{name}]({relative_link(base_path, REPORT_SPECS[name][0])})" for name in report_names if name in REPORT_SPECS]
    return "、".join(links)


def generate_tree(root: Path, extra_ignores: Sequence[str] = ()) -> Tuple[str, List[Tuple[str, str]]]:
    entries = 0
    explanations: List[Tuple[str, str]] = []

    def describe(path: Path) -> str:
        name = path.name
        if path.is_dir():
            return DIR_DESCRIPTIONS.get(name, "")
        return FILE_DESCRIPTIONS.get(name, "")

    def line_for(path: Path, prefix: str, is_last: bool) -> str:
        nonlocal entries
        entries += 1
        connector = "└── " if is_last else "├── "
        desc = describe(path)
        label = path.name + ("/" if path.is_dir() else "")
        if desc:
            explanations.append((rel(path, root), desc))
            return f"{prefix}{connector}{label}  # {desc}"
        return f"{prefix}{connector}{label}"

    def children(path: Path) -> List[Path]:
        try:
            items = [p for p in path.iterdir() if not is_ignored(p, root, extra_ignores)]
        except Exception:
            return []
        items.sort(key=lambda p: (not p.is_dir(), p.name.lower()))
        return items

    lines = [f"{root.name or root.as_posix()}/  # 项目根目录"]

    def rec(path: Path, prefix: str = "") -> None:
        nonlocal entries
        if entries >= MAX_TREE_ENTRIES:
            lines.append(prefix + "└── ...  # 目录树过长，已截断")
            return
        kids = children(path)
        for idx, child in enumerate(kids):
            is_last = idx == len(kids) - 1
            lines.append(line_for(child, prefix, is_last))
            if child.is_dir():
                rec(child, prefix + ("    " if is_last else "│   "))

    rec(root)
    return "\n".join(lines), explanations


def write_directory_tree(root: Path, out: Path, profile: ProjectProfile, extra_ignores: Sequence[str] = ()) -> None:
    tree_ignores = build_tree_ignores(root, out, extra_ignores)
    tree, explanations = generate_tree(root, tree_ignores)
    langs = ", ".join(profile.primary_languages) or "未识别"
    ignored = sorted(set(DEFAULT_IGNORES) | set(tree_ignores))
    important = "\n".join([f"- `{p}`：{d}" for p, d in explanations[:120]]) or "- 未识别到需要特别说明的关键文件。"
    output_ignores = output_ignore_patterns(root, out)
    output_ignore_text = "、".join(f"`{item}`" for item in output_ignores) if output_ignores else "当前输出目录不在项目根目录内"
    content = f"""# 项目目录树

生成时间：`{now_iso()}`  
项目根目录：`{root}`  
识别语言：{langs}

## 图例

- `/` 结尾表示目录。
- `#` 后面是中文说明。
- 该目录树会自动忽略缓存、依赖、构建产物、Graphify 输出，以及本次证据输出目录（{output_ignore_text}），避免干扰 AI 阅读。

## 已忽略目录/路径

```text
{chr(10).join(ignored)}
```

## 中文目录树

```text
{tree}
```

## 关键目录和文件说明

{important}
"""
    write(out / OVERVIEW_FILES["directory_tree"], content)


def write_usage_guide(out: Path, report_names: Sequence[str]) -> None:
    usage_path = OVERVIEW_FILES["usage"]
    entries = navigation_entries(report_names)
    nav_lines = [
        f"| `{category}` | [{label}]({relative_link(usage_path, path)}) | {description} |"
        for category, path, label, description in entries
    ]
    quality_reports = [name for name in report_names if REPORT_SPECS.get(name, (Path(), ""))[0].parent == QUALITY_DIR]
    security_reports = [name for name in report_names if REPORT_SPECS.get(name, (Path(), ""))[0].parent == SECURITY_DIR]
    dependency_reports = [name for name in report_names if REPORT_SPECS.get(name, (Path(), ""))[0].parent == DEPENDENCY_DIR]
    read_steps = [
        f"1. [验证摘要]({relative_link(usage_path, OVERVIEW_FILES['summary'])})：先看整体状态和关键入口。",
        f"2. [中文目录树]({relative_link(usage_path, OVERVIEW_FILES['directory_tree'])})：再看项目结构和关键文件说明。",
        f"3. [运行环境]({relative_link(usage_path, OVERVIEW_FILES['runtime'])})：确认语言、包管理器和常用命令。",
    ]
    if quality_reports:
        read_steps.append(f"4. {joined_links(usage_path, quality_reports)}：判断改动是否稳定。")
    if security_reports or dependency_reports:
        combined_reports = security_reports + dependency_reports
        step_no = len(read_steps) + 1
        read_steps.append(f"{step_no}. {joined_links(usage_path, combined_reports)}：在安全或依赖变更时补充查看。")
    content = f"""# 使用说明

生成时间：`{now_iso()}`

当前证据目录采用固定中文分类收口，根目录只保留入口文件 [`README.md`]({relative_link(usage_path, ROOT_README)})。

## 分类导航

| 分类 | 关键文件 | 说明 |
|---|---|---|
{chr(10).join(nav_lines)}

## 推荐阅读顺序

{chr(10).join(read_steps)}

## 常用命令示例

```bash
python project_evidence_fixed.py doctor --root . --out docs/evidence
python project_evidence_fixed.py verify --root . --out docs/evidence
python project_evidence_fixed.py full --root . --out docs/evidence
python project_evidence_fixed.py install
python project_evidence_fixed.py install --yes
```
"""
    write(out / usage_path, content)


def write_readme(out: Path, report_names: Sequence[str]) -> None:
    readme_path = ROOT_README
    entries = navigation_entries(report_names)
    nav_lines = [
        f"| `{category}` | [{label}]({relative_link(readme_path, path)}) | {description} |"
        for category, path, label, description in entries
    ]
    content = f"""# 项目验证证据入口

生成时间：`{now_iso()}`

本目录由 `project_evidence_fixed.py` 生成，根目录只保留入口导航；详细说明见 [使用说明]({relative_link(readme_path, OVERVIEW_FILES["usage"])})。

## 导航

| 分类 | 文件 | 用途 |
|---|---|---|
{chr(10).join(nav_lines)}
"""
    write(out / readme_path, content)


def write_profile(profile: ProjectProfile, out: Path) -> None:
    data = {
        "generated_at": now_iso(),
        "root": str(profile.root),
        "primary_languages": profile.primary_languages,
        "languages": profile.languages,
        "marker_hits": profile.marker_hits,
        "package_managers": profile.package_managers,
        "source_file_count": profile.source_file_count,
        "total_file_count": profile.total_file_count,
        "important_files": profile.important_files,
    }
    write(out / OVERVIEW_FILES["project_profile"], json.dumps(data, ensure_ascii=False, indent=2))


def write_runtime(profile: ProjectProfile, out: Path) -> None:
    root = profile.root
    lines = [
        "# 运行环境和项目命令",
        "",
        f"生成时间：`{now_iso()}`",
        "",
        "## 系统环境",
        "",
        f"- 操作系统：`{platform.platform()}`",
        f"- Python：`{sys.version.split()[0]}`",
        f"- 当前目录：`{Path.cwd()}`",
        f"- 项目根目录：`{root}`",
        "",
        "## 识别结果",
        "",
        f"- 主要语言：{', '.join(profile.primary_languages) or '未识别'}",
        f"- 包管理器：{', '.join(profile.package_managers) or '未识别'}",
        f"- 源码文件数：`{profile.source_file_count}`",
        f"- 总文件数：`{profile.total_file_count}`",
        "",
        "## 常用命令推断",
        "",
    ]
    commands: List[Tuple[str, str]] = []
    data = package_json(root)
    scripts = data.get("scripts", {}) if isinstance(data, dict) else {}
    if isinstance(scripts, dict):
        for name in ["dev", "start", "test", "lint", "format", "typecheck", "type-check", "build"]:
            if name in scripts:
                commands.append((f"package.json scripts.{name}", f"{node_runner(root)} run {name}" if node_runner(root) == "npm" else f"{node_runner(root)} {name}"))
    if (root / "pyproject.toml").exists() or (root / "requirements.txt").exists():
        commands.extend([
            ("Python 测试", "pytest"),
            ("Python lint", "ruff check ."),
            ("Python 格式化检查", "ruff format --check ."),
            ("Python 类型检查", "pyright ."),
        ])
    if (root / "go.mod").exists():
        commands.extend([("Go 测试", "go test ./..."), ("Go 构建", "go build ./...")])
    if (root / "Cargo.toml").exists():
        commands.extend([("Rust 检查", "cargo check"), ("Rust 测试", "cargo test"), ("Rust 构建", "cargo build")])
    if (root / "pom.xml").exists():
        commands.extend([("Maven 测试", "mvn test"), ("Maven 打包", "mvn package")])
    if (root / "build.gradle").exists() or (root / "build.gradle.kts").exists():
        gradle_cmd = "gradlew" if (root / "gradlew").exists() else "gradle"
        commands.extend([("Gradle 检查", f"{gradle_cmd} check"), ("Gradle 构建", f"{gradle_cmd} build")])
    if commands:
        lines.extend(["| 类型 | 命令 |", "|---|---|"])
        for label, cmd in commands:
            lines.append(f"| {label} | `{cmd}` |")
    else:
        lines.append("未从项目配置中识别到常用命令。")
    lines.append("")
    write(out / OVERVIEW_FILES["runtime"], "\n".join(lines))


def available_tools(profile: ProjectProfile) -> Dict[str, List[str]]:
    langs = set(profile.primary_languages)
    tools: Dict[str, List[str]] = {}
    if "Python" in langs:
        tools["Python"] = ["pyright", "ruff", "radon", "bandit", "semgrep", "gitleaks", "pipdeptree", "pip-audit", "pytest", "python"]
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"}:
        tools["JS/TS"] = ["node", "npm", "pnpm", "yarn", "bun", "tsc", "eslint", "prettier", "semgrep", "gitleaks"]
    if "Go" in langs:
        tools["Go"] = ["go", "golangci-lint", "govulncheck", "gitleaks", "semgrep"]
    if "Rust" in langs:
        tools["Rust"] = ["cargo", "rustc", "cargo-audit", "gitleaks", "semgrep"]
    if langs & {"Java", "Kotlin", "Scala"}:
        tools["JVM"] = ["java", "mvn", "gradle", "semgrep", "gitleaks"]
    if "C#/.NET" in langs:
        tools[".NET"] = ["dotnet", "semgrep", "gitleaks"]
    if langs & {"C/C++", "Objective-C"}:
        tools["C/C++"] = ["cmake", "make", "clang-tidy", "cppcheck", "semgrep", "gitleaks"]
    if not tools:
        tools["通用"] = ["semgrep", "gitleaks"]
    return tools


def write_tool_versions(profile: ProjectProfile, out: Path) -> None:
    tools = available_tools(profile)
    lines = ["# 工具版本", "", f"生成时间：`{now_iso()}`", ""]
    for group, names in tools.items():
        lines.append(f"## {group}")
        lines.append("")
        lines.append("| 工具 | 状态 | 版本/路径 |")
        lines.append("|---|---|---|")
        for name in names:
            path = which(name)
            if not path:
                lines.append(f"| `{name}` | 未安装 | - |")
                continue
            version = get_version(name)
            lines.append(f"| `{name}` | 已安装 | `{version or path}` |")
        lines.append("")
    write(out / OVERVIEW_FILES["tool_versions"], "\n".join(lines))


def get_version(cmd: str) -> str:
    variants = [[cmd, "--version"], [cmd, "-V"], [cmd, "version"]]
    for v in variants:
        try:
            p = subprocess.run(v, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True, errors="replace", timeout=8)
            text = (p.stdout or p.stderr or "").strip().splitlines()
            if text:
                return text[0][:200]
        except Exception:
            pass
    return which(cmd) or ""


def write_result_file(out: Path, relative_path: Path, title: str, results: List[CommandResult]) -> None:
    lines = [f"# {title}", "", f"生成时间：`{now_iso()}`", ""]
    if not results:
        lines.append("没有适用于当前项目的检查命令。")
    else:
        for result in results:
            lines.append(md_command_result(result))
            lines.append("---")
            lines.append("")
    write(out / relative_path, "\n".join(lines))


def commands_type_check(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python 类型检查：pyright", ["pyright", "."], COMMAND_TIMEOUT))
    if langs & {"TypeScript", "Vue", "Svelte"}:
        if (root / "tsconfig.json").exists():
            cmds.append(("TypeScript 类型检查：tsc --noEmit", ["npx", "tsc", "--noEmit"], COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go 测试/类型检查：go test ./...", ["go", "test", "./..."], FULL_COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust 类型检查：cargo check", ["cargo", "check"], FULL_COMMAND_TIMEOUT))
    if "C#/.NET" in langs:
        cmds.append((".NET 构建检查：dotnet build --no-restore", ["dotnet", "build", "--no-restore"], FULL_COMMAND_TIMEOUT))
    if "Java" in langs and (root / "pom.xml").exists():
        cmds.append(("Java Maven 编译检查", ["mvn", "-q", "-DskipTests", "compile"], FULL_COMMAND_TIMEOUT))
    if langs & {"Java", "Kotlin", "Scala"} and ((root / "build.gradle").exists() or (root / "build.gradle.kts").exists()):
        gradle = "./gradlew" if (root / "gradlew").exists() else "gradle"
        cmds.append(("Gradle 编译检查", [gradle, "classes"], FULL_COMMAND_TIMEOUT))
    return cmds


def commands_lint(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python lint：ruff check", ["ruff", "check", "."], COMMAND_TIMEOUT))
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"}:
        if has_package_script(root, "lint"):
            cmds.append(("Node lint：package.json lint", node_run_cmd(root, "lint"), COMMAND_TIMEOUT))
        else:
            cmds.append(("Node lint：eslint", ["npx", "eslint", "."], COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go lint：golangci-lint", ["golangci-lint", "run"], FULL_COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust lint：cargo clippy", ["cargo", "clippy", "--", "-D", "warnings"], FULL_COMMAND_TIMEOUT))
    return cmds


def commands_format(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python 格式化检查：ruff format --check", ["ruff", "format", "--check", "."], COMMAND_TIMEOUT))
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"}:
        cmds.append(("Node 格式化检查：prettier --check", ["npx", "prettier", "--check", "."], COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go 格式化检查：gofmt", ["gofmt", "-l", "."], COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust 格式化检查：cargo fmt --check", ["cargo", "fmt", "--check"], COMMAND_TIMEOUT))
    return cmds


def commands_complexity(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python 复杂度：radon cc", ["radon", "cc", ".", "-s", "-a"], COMMAND_TIMEOUT))
        cmds.append(("Python 可维护性：radon mi", ["radon", "mi", ".", "-s"], COMMAND_TIMEOUT))
    # lizard 多语言，但不是强制要求；如果装了就跑。
    if which("lizard"):
        cmds.append(("通用复杂度：lizard", ["lizard", "."], COMMAND_TIMEOUT))
    return cmds


def commands_security(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if which("semgrep"):
        cmds.append(("通用源码安全扫描：semgrep", ["semgrep", "--config", "auto", "--error", "."], FULL_COMMAND_TIMEOUT))
    else:
        cmds.append(("通用源码安全扫描：semgrep", ["semgrep", "--config", "auto", "--error", "."], FULL_COMMAND_TIMEOUT))
    if "Python" in langs:
        cmds.append(("Python 安全扫描：bandit", ["bandit", "-r", "."], COMMAND_TIMEOUT))
    return cmds


def commands_secrets(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    return [("Secret 泄露扫描：gitleaks", ["gitleaks", "detect", "--source", ".", "--no-git", "--redact"], COMMAND_TIMEOUT)]


def commands_dependency_tree(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python 依赖树：pipdeptree", ["pipdeptree"], COMMAND_TIMEOUT))
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"}:
        runner = node_runner(root)
        if runner == "pnpm":
            cmds.append(("pnpm 依赖树", ["pnpm", "list", "--depth", "10"], COMMAND_TIMEOUT))
        elif runner == "yarn":
            cmds.append(("Yarn 依赖树", ["yarn", "list"], COMMAND_TIMEOUT))
        elif runner == "bun":
            cmds.append(("Bun 依赖树", ["bun", "pm", "ls"], COMMAND_TIMEOUT))
        else:
            cmds.append(("npm 依赖树", ["npm", "ls", "--all"], COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go 依赖列表", ["go", "list", "-m", "all"], COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust 依赖树：cargo tree", ["cargo", "tree"], COMMAND_TIMEOUT))
    if "Java" in langs and (root / "pom.xml").exists():
        cmds.append(("Maven 依赖树", ["mvn", "dependency:tree"], FULL_COMMAND_TIMEOUT))
    if langs & {"Java", "Kotlin", "Scala"} and ((root / "build.gradle").exists() or (root / "build.gradle.kts").exists()):
        gradle = "./gradlew" if (root / "gradlew").exists() else "gradle"
        cmds.append(("Gradle 依赖树", [gradle, "dependencies"], FULL_COMMAND_TIMEOUT))
    return cmds


def commands_dependency_vulns(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python 依赖漏洞：pip-audit", ["pip-audit"], FULL_COMMAND_TIMEOUT))
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"}:
        runner = node_runner(root)
        if runner == "pnpm":
            cmds.append(("pnpm audit", ["pnpm", "audit"], FULL_COMMAND_TIMEOUT))
        elif runner == "yarn":
            cmds.append(("Yarn audit", ["yarn", "npm", "audit"], FULL_COMMAND_TIMEOUT))
        elif runner == "bun":
            cmds.append(("Bun audit", ["bun", "audit"], FULL_COMMAND_TIMEOUT))
        else:
            cmds.append(("npm audit", ["npm", "audit"], FULL_COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go 依赖漏洞：govulncheck", ["govulncheck", "./..."], FULL_COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust 依赖漏洞：cargo audit", ["cargo", "audit"], FULL_COMMAND_TIMEOUT))
    return cmds


def commands_tests(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if "Python" in langs:
        cmds.append(("Python 测试：pytest", ["pytest"], FULL_COMMAND_TIMEOUT))
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"} and has_package_script(root, "test"):
        cmds.append(("Node 测试：package.json test", node_run_cmd(root, "test"), FULL_COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go 测试：go test ./...", ["go", "test", "./..."], FULL_COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust 测试：cargo test", ["cargo", "test"], FULL_COMMAND_TIMEOUT))
    if "Java" in langs and (root / "pom.xml").exists():
        cmds.append(("Maven 测试", ["mvn", "test"], FULL_COMMAND_TIMEOUT))
    if langs & {"Java", "Kotlin", "Scala"} and ((root / "build.gradle").exists() or (root / "build.gradle.kts").exists()):
        gradle = "./gradlew" if (root / "gradlew").exists() else "gradle"
        cmds.append(("Gradle 测试", [gradle, "test"], FULL_COMMAND_TIMEOUT))
    return cmds


def commands_build(profile: ProjectProfile) -> List[Tuple[str, List[str], int]]:
    root = profile.root
    langs = set(profile.primary_languages)
    cmds: List[Tuple[str, List[str], int]] = []
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"} and has_package_script(root, "build"):
        cmds.append(("Node 构建：package.json build", node_run_cmd(root, "build"), FULL_COMMAND_TIMEOUT))
    if "Python" in langs and (root / "pyproject.toml").exists():
        cmds.append(("Python 构建：python -m build", [sys.executable, "-m", "build"], FULL_COMMAND_TIMEOUT))
    if "Go" in langs:
        cmds.append(("Go 构建：go build ./...", ["go", "build", "./..."], FULL_COMMAND_TIMEOUT))
    if "Rust" in langs:
        cmds.append(("Rust 构建：cargo build", ["cargo", "build"], FULL_COMMAND_TIMEOUT))
    if "C#/.NET" in langs:
        cmds.append((".NET 构建", ["dotnet", "build"], FULL_COMMAND_TIMEOUT))
    if "Java" in langs and (root / "pom.xml").exists():
        cmds.append(("Maven 打包", ["mvn", "package"], FULL_COMMAND_TIMEOUT))
    if langs & {"Java", "Kotlin", "Scala"} and ((root / "build.gradle").exists() or (root / "build.gradle.kts").exists()):
        gradle = "./gradlew" if (root / "gradlew").exists() else "gradle"
        cmds.append(("Gradle 构建", [gradle, "build"], FULL_COMMAND_TIMEOUT))
    return cmds


def run_group(profile: ProjectProfile, out: Path, relative_path: Path, title: str, commands: List[Tuple[str, List[str], int]]) -> List[CommandResult]:
    results = [run_command(name, cmd, profile.root, timeout=timeout) for name, cmd, timeout in commands]
    write_result_file(out, relative_path, title, results)
    return results


def build_common(profile: ProjectProfile, out: Path, extra_ignores: Sequence[str] = ()) -> None:
    cleanup_legacy_outputs(out)
    ensure_output_dirs(out)
    write_profile(profile, out)
    write_directory_tree(profile.root, out, profile, extra_ignores)
    write_runtime(profile, out)
    write_tool_versions(profile, out)


def write_summary(profile: ProjectProfile, out: Path, groups: Dict[str, List[CommandResult]], report_names: Sequence[str]) -> None:
    summary_path = OVERVIEW_FILES["summary"]
    quality_reports = [name for name in report_names if REPORT_SPECS.get(name, (Path(), ""))[0].parent == QUALITY_DIR]
    security_reports = [name for name in report_names if REPORT_SPECS.get(name, (Path(), ""))[0].parent == SECURITY_DIR]
    dependency_reports = [name for name in report_names if REPORT_SPECS.get(name, (Path(), ""))[0].parent == DEPENDENCY_DIR]
    lines = [
        "# 验证摘要",
        "",
        f"生成时间：`{now_iso()}`",
        f"项目根目录：`{profile.root}`",
        "",
        "## 项目识别",
        "",
        f"- 主要语言：{', '.join(profile.primary_languages) or '未识别'}",
        f"- 包管理器：{', '.join(profile.package_managers) or '未识别'}",
        f"- 源码文件数：`{profile.source_file_count}`",
        f"- 总文件数：`{profile.total_file_count}`",
        "",
        "## 验证结果总览",
        "",
        "| 证据 | 状态 | 通过 | 失败 | 跳过 | 报告 |",
        "|---|---:|---:|---:|---:|---|",
    ]
    for name, results in groups.items():
        passed = sum(1 for r in results if r.ok and not r.skipped)
        failed = sum(1 for r in results if (not r.ok) and not r.skipped)
        skipped = sum(1 for r in results if r.skipped)
        if not results:
            status = "无适用命令"
        elif failed:
            status = "失败"
        elif passed and not failed:
            status = "通过"
        else:
            status = "跳过"
        report_path = REPORT_SPECS.get(name, (Path(), ""))[0]
        report_link = f"[查看报告]({relative_link(summary_path, report_path)})" if report_path else ""
        lines.append(f"| {name} | {status} | {passed} | {failed} | {skipped} | {report_link} |")
    lines.extend([
        "",
        "## 建议阅读顺序",
        "",
        f"1. [使用说明]({relative_link(summary_path, OVERVIEW_FILES['usage'])})：先看命令示例和整体导航。",
        f"2. [中文目录树]({relative_link(summary_path, OVERVIEW_FILES['directory_tree'])})：了解项目结构。",
        f"3. [运行环境]({relative_link(summary_path, OVERVIEW_FILES['runtime'])})：确认语言、包管理器、测试/构建命令。",
        "",
        "## 关键文件",
        "",
    ])
    insert_at = len(lines) - 3
    extra_steps: List[str] = []
    if quality_reports:
        extra_steps.append(f"4. {joined_links(summary_path, quality_reports)}：确认代码修改是否可靠。")
    if security_reports or dependency_reports:
        step_no = 4 + len(extra_steps)
        extra_steps.append(f"{step_no}. {joined_links(summary_path, security_reports + dependency_reports)}：在安全或依赖变更时补充查看。")
    lines[insert_at:insert_at] = extra_steps + ([""] if extra_steps else [])
    if profile.important_files:
        lines.extend([f"- `{p}`" for p in profile.important_files[:100]])
    else:
        lines.append("未识别到关键配置文件。")
    write(out / summary_path, "\n".join(lines))


def cmd_doctor(args: argparse.Namespace) -> int:
    root = Path(args.root).resolve()
    out = resolve_out(root, args.out)
    profile = detect_project(root, args.ignore)
    build_common(profile, out, args.ignore)
    groups: Dict[str, List[CommandResult]] = {}
    report_names: List[str] = []
    write_summary(profile, out, groups, report_names)
    write_readme(out, report_names)
    write_usage_guide(out, report_names)
    print(f"项目根目录: {root}")
    print(f"输出目录: {out}")
    print(f"识别语言: {', '.join(profile.primary_languages) or '未识别'}")
    print(f"包管理器: {', '.join(profile.package_managers) or '未识别'}")
    print("已生成：README.md、00-总览/使用说明.md、00-总览/验证摘要.md、00-总览/中文目录树.md、00-总览/运行环境.md、00-总览/工具版本.md、00-总览/项目画像.json")
    return 0


def cmd_verify(args: argparse.Namespace) -> int:
    root = Path(args.root).resolve()
    out = resolve_out(root, args.out)
    profile = detect_project(root, args.ignore)
    build_common(profile, out, args.ignore)
    groups: Dict[str, List[CommandResult]] = {}
    groups["类型检查"] = run_group(profile, out, REPORT_SPECS["类型检查"][0], REPORT_SPECS["类型检查"][1], commands_type_check(profile))
    groups["代码风格检查"] = run_group(profile, out, REPORT_SPECS["代码风格检查"][0], REPORT_SPECS["代码风格检查"][1], commands_lint(profile))
    groups["格式检查"] = run_group(profile, out, REPORT_SPECS["格式检查"][0], REPORT_SPECS["格式检查"][1], commands_format(profile))
    groups["复杂度检查"] = run_group(profile, out, REPORT_SPECS["复杂度检查"][0], REPORT_SPECS["复杂度检查"][1], commands_complexity(profile))
    groups["测试结果"] = run_group(profile, out, REPORT_SPECS["测试结果"][0], REPORT_SPECS["测试结果"][1], commands_tests(profile))
    report_names = list(groups.keys())
    write_summary(profile, out, groups, report_names)
    write_readme(out, report_names)
    write_usage_guide(out, report_names)
    print(f"verify 完成，输出目录：{out}")
    return exit_code_from_groups(groups)


def cmd_full(args: argparse.Namespace) -> int:
    root = Path(args.root).resolve()
    out = resolve_out(root, args.out)
    profile = detect_project(root, args.ignore)
    build_common(profile, out, args.ignore)
    groups: Dict[str, List[CommandResult]] = {}
    groups["类型检查"] = run_group(profile, out, REPORT_SPECS["类型检查"][0], REPORT_SPECS["类型检查"][1], commands_type_check(profile))
    groups["代码风格检查"] = run_group(profile, out, REPORT_SPECS["代码风格检查"][0], REPORT_SPECS["代码风格检查"][1], commands_lint(profile))
    groups["格式检查"] = run_group(profile, out, REPORT_SPECS["格式检查"][0], REPORT_SPECS["格式检查"][1], commands_format(profile))
    groups["复杂度检查"] = run_group(profile, out, REPORT_SPECS["复杂度检查"][0], REPORT_SPECS["复杂度检查"][1], commands_complexity(profile))
    groups["安全扫描"] = run_group(profile, out, REPORT_SPECS["安全扫描"][0], REPORT_SPECS["安全扫描"][1], commands_security(profile))
    groups["敏感信息扫描"] = run_group(profile, out, REPORT_SPECS["敏感信息扫描"][0], REPORT_SPECS["敏感信息扫描"][1], commands_secrets(profile))
    groups["依赖树"] = run_group(profile, out, REPORT_SPECS["依赖树"][0], REPORT_SPECS["依赖树"][1], commands_dependency_tree(profile))
    groups["依赖漏洞"] = run_group(profile, out, REPORT_SPECS["依赖漏洞"][0], REPORT_SPECS["依赖漏洞"][1], commands_dependency_vulns(profile))
    groups["测试结果"] = run_group(profile, out, REPORT_SPECS["测试结果"][0], REPORT_SPECS["测试结果"][1], commands_tests(profile))
    groups["构建结果"] = run_group(profile, out, REPORT_SPECS["构建结果"][0], REPORT_SPECS["构建结果"][1], commands_build(profile))
    report_names = list(groups.keys())
    write_summary(profile, out, groups, report_names)
    write_readme(out, report_names)
    write_usage_guide(out, report_names)
    print(f"full 完成，输出目录：{out}")
    return exit_code_from_groups(groups)


def exit_code_from_groups(groups: Dict[str, List[CommandResult]]) -> int:
    # 跳过不算失败；命令实际执行失败则返回 1。
    for results in groups.values():
        for r in results:
            if not r.skipped and not r.ok:
                return 1
    return 0


def resolve_out(root: Path, out_arg: str) -> Path:
    p = Path(out_arg)
    if p.is_absolute():
        return p
    return (root / p).resolve()


def install_plan(profile: ProjectProfile) -> List[Tuple[str, List[str], str]]:
    root = profile.root
    langs = set(profile.primary_languages)
    plan: List[Tuple[str, List[str], str]] = []

    def add(tool: str, cmd: List[str], reason: str) -> None:
        if not which(tool):
            plan.append((tool, cmd, reason))

    if "Python" in langs:
        add("pyright", [sys.executable, "-m", "pip", "install", "pyright"], "Python 类型检查")
        add("ruff", [sys.executable, "-m", "pip", "install", "ruff"], "Python lint/format")
        add("radon", [sys.executable, "-m", "pip", "install", "radon"], "Python 复杂度")
        add("bandit", [sys.executable, "-m", "pip", "install", "bandit"], "Python 安全扫描")
        add("pipdeptree", [sys.executable, "-m", "pip", "install", "pipdeptree"], "Python 依赖树")
        add("pip-audit", [sys.executable, "-m", "pip", "install", "pip-audit"], "Python 依赖漏洞")
        add("pytest", [sys.executable, "-m", "pip", "install", "pytest"], "Python 测试")
    if langs & {"JavaScript", "TypeScript", "Vue", "Svelte"}:
        if which("npm") and not which("tsc"):
            plan.append(("tsc", ["npm", "install", "-D", "typescript"], "TypeScript 类型检查"))
        if which("npm") and not which("eslint"):
            plan.append(("eslint", ["npm", "install", "-D", "eslint"], "JS/TS lint"))
        if which("npm") and not which("prettier"):
            plan.append(("prettier", ["npm", "install", "-D", "prettier"], "JS/TS 格式化检查"))
    # 通用工具：默认只列出，不强制安装；semgrep/gitleaks 安装方式因系统差异大。
    if not which("semgrep"):
        plan.append(("semgrep", [sys.executable, "-m", "pip", "install", "semgrep"], "通用源码安全扫描"))
    if not which("gitleaks"):
        plan.append(("gitleaks", [], "Secret 扫描。建议通过系统包管理器安装，例如 brew install gitleaks / scoop install gitleaks / apt 安装或下载二进制。"))
    if "Go" in langs:
        if not which("golangci-lint"):
            plan.append(("golangci-lint", [], "Go lint。建议按 golangci-lint 官方方式安装。"))
        if not which("govulncheck"):
            plan.append(("govulncheck", ["go", "install", "golang.org/x/vuln/cmd/govulncheck@latest"], "Go 依赖漏洞"))
    if "Rust" in langs:
        if not which("cargo-audit"):
            plan.append(("cargo-audit", ["cargo", "install", "cargo-audit"], "Rust 依赖漏洞"))
    return plan


def cmd_install(args: argparse.Namespace) -> int:
    root = Path(args.root).resolve()
    profile = detect_project(root, args.ignore)
    plan = install_plan(profile)
    if not plan:
        print("没有发现需要安装的工具。")
        return 0
    print("缺失工具增量安装计划：")
    for tool, cmd, reason in plan:
        print(f"- {tool}: {reason}")
        if cmd:
            print(f"  命令: {' '.join(cmd)}")
        else:
            print("  命令: 未自动安装，请按工具官方方式安装。")
    if not args.yes:
        print("\n默认不会安装。确认要安装时运行：install --yes")
        return 0
    failed = 0
    for tool, cmd, reason in plan:
        if not cmd:
            print(f"跳过 {tool}: 没有安全的跨平台自动安装命令。")
            continue
        print(f"安装 {tool}...")
        result = run_command(f"安装 {tool}", cmd, root, timeout=FULL_COMMAND_TIMEOUT)
        if result.ok:
            print(f"已安装/已执行：{tool}")
        else:
            failed += 1
            print(f"安装失败：{tool}")
            if result.stderr:
                print(result.stderr[-2000:])
            elif result.stdout:
                print(result.stdout[-2000:])
            elif result.reason:
                print(result.reason)
    return 1 if failed else 0


def make_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(description="项目验证证据生成器：生成中文目录树、类型检查、lint、安全、复杂度、依赖、测试、构建等 Markdown 报告。")
    parser.add_argument("--version", action="version", version=f"project_evidence_fixed.py {VERSION}")
    sub = parser.add_subparsers(dest="command", required=True)

    def common(p: argparse.ArgumentParser) -> None:
        p.add_argument("--root", default=".", help="项目根目录。默认：当前目录。")
        p.add_argument("--out", default="docs/evidence", help="输出目录。相对路径会基于 --root。默认：docs/evidence")
        p.add_argument("--ignore", action="append", default=[], help="额外忽略路径/模式，可多次传入。")

    p = sub.add_parser("doctor", help="只识别项目、生成中文目录树/运行环境/工具版本，不跑验证命令。")
    common(p)
    p.set_defaults(func=cmd_doctor)

    p = sub.add_parser("verify", help="快速验证：类型检查、lint、格式化、复杂度、测试。")
    common(p)
    p.set_defaults(func=cmd_verify)

    p = sub.add_parser("full", help="完整验证：verify + 安全扫描、Secret、依赖树、依赖漏洞、构建。")
    common(p)
    p.set_defaults(func=cmd_full)

    p = sub.add_parser("install", help="列出或增量安装缺失工具。默认只列计划，加 --yes 才安装。")
    common(p)
    p.add_argument("--yes", action="store_true", help="实际执行安装。")
    p.set_defaults(func=cmd_install)

    return parser


def main(argv: Optional[Sequence[str]] = None) -> int:
    parser = make_parser()
    args = parser.parse_args(argv)
    return int(args.func(args))


if __name__ == "__main__":
    raise SystemExit(main())
