#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
SOURCE_DIR="$(cd -- "${SCRIPT_DIR}/.." && pwd)"
DEFAULT_TARGET="/mnt/c/Users/14745/Desktop/worldbox/worldbox/Mods/EraWheel"
TARGET_DIR="${1:-${WORLD_BOX_MOD_DIR:-$DEFAULT_TARGET}}"
SOURCE_REAL="$(readlink -f "$SOURCE_DIR")"
TARGET_REAL="$(readlink -f "$TARGET_DIR")"

if [[ ! -d "$SOURCE_DIR/src" ]]; then
  echo "Source folder is invalid: $SOURCE_DIR" >&2
  exit 1
fi

if [[ ! -d "$TARGET_DIR" ]]; then
  echo "Target folder not found: $TARGET_DIR" >&2
  exit 1
fi

if ! command -v rsync >/dev/null 2>&1; then
  echo "rsync is required but not found." >&2
  exit 1
fi

if [[ "$SOURCE_REAL" == "$TARGET_REAL" ]]; then
  echo "Source and target are the same directory: $SOURCE_REAL" >&2
  exit 1
fi

echo "Syncing EraWheel source:"
echo "  from: $SOURCE_REAL"
echo "  to:   $TARGET_REAL"

rsync -a --delete \
  --exclude ".git/" \
  --exclude "bin/" \
  --exclude "obj/" \
  --exclude ".DS_Store" \
  "$SOURCE_DIR/" "$TARGET_DIR/"

declare -a VERIFY_FILES=(
  "src/UI/EraUiBootstrap.cs"
  "src/EraWheel.cs"
  "src/Combat/Statuses/EraStatusRuntimeService.cs"
  "src/Combat/Triggers/EraTriggerService.cs"
)

echo "Verifying key source hashes:"
for rel_path in "${VERIFY_FILES[@]}"; do
  src_file="$SOURCE_DIR/$rel_path"
  dst_file="$TARGET_DIR/$rel_path"

  if [[ ! -f "$src_file" || ! -f "$dst_file" ]]; then
    echo "Missing verification file: $rel_path" >&2
    exit 1
  fi

  src_hash="$(sha256sum "$src_file" | awk '{print $1}')"
  dst_hash="$(sha256sum "$dst_file" | awk '{print $1}')"
  echo "  $rel_path"
  echo "    src=$src_hash"
  echo "    dst=$dst_hash"
  if [[ "$src_hash" != "$dst_hash" ]]; then
    echo "Hash mismatch: $rel_path" >&2
    exit 1
  fi
done

echo "Sync complete. Key source files are consistent."
