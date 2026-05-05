# WorldBox 原版军队 UI 提取说明

## 来源

- `Observed`：本目录中的 PNG 由真实游戏安装目录 `/mnt/c/Users/14745/Desktop/worldbox/worldbox/worldbox_Data/resources.assets` 提取。
- `Observed`：提取时使用了 Unity 资源读取，按 `Sprite.m_Name` 精确导出，不是手工截图裁切。

## 这批图主要分组

- 窗口底板：`windowBig`、`windowBigNoTitle`、`windowBigTR`、`windowBig_TopSlice`
- 内层容器：`windowInnerSliced`、`windowInnerSlicedSmall`、`windowInnerSlicedRound`、`windowInnerSlicedRoundWhite`、`windowInnerSlicedTopRound`、`windowBar`
- 按钮底图：`special_buttonGray`、`special_buttonRed`、`backgroundBackButton`、`backgroundTabButton`
- Tab 内容容器：`background_tab_content`、`background_tab_content_2`、`background_tab_content_small`
- 页签底图：`tab_button`、`tab_button_selected`、`tab_button_sort`、`tab_button_sort_selected`、`tab_button_vertical`、`tab_button_vertical_right`、`tab_button_vertical_selected`、`tab_button_vertical_selected_right`
- 横幅拼图：`banner_part_background0-7`、`banner_part_object0-7`
- 图标：`iconArmy`、`iconArmyList`、`iconArmyAttackers`、`iconArmyDefenders`、`iconArrowDOWN`、`iconArrowUP`、`iconBooks`、`iconBooksRead`、`iconBooksWritten`、`iconBooksDestroyed`、`iconClose`、`iconCrown`、`iconKingdom`、`iconKingdomList`、`iconOn`、`iconOptions`、`iconSaveCloud`、`iconShield`、`iconStatistics`、`iconWar`、`iconWarList`、`iconWarriors`
- 其他小底板：`windowNamePlate`

## 预览

- `_sheet_all.png` 是当前目录素材总览。

## 额外说明

- `Observed`：`background_tab_content.png` 是从真实 `resources.assets` 新补提的原版 sprite。
- `Observed`：它属于 tab 内容容器框，不是单个 tab 按钮底图。
