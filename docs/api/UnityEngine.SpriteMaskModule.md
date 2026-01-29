# Assembly: UnityEngine.SpriteMaskModule
- Path: tools/WorldBox.Managed/UnityEngine.SpriteMaskModule.dll
- Types: 2

## Namespace: UnityEngine

### public class UnityEngine.SpriteMask
- Base: UnityEngine.Renderer

#### Properties
- public float alphaCutoff { get; set; }
- public int backSortingLayerID { get; set; }
- public int backSortingOrder { get; set; }
- public int frontSortingLayerID { get; set; }
- public int frontSortingOrder { get; set; }
- public bool isCustomRangeActive { get; set; }
- public UnityEngine.Sprite sprite { get; set; }
- public UnityEngine.SpriteSortPoint spriteSortPoint { get; set; }

#### Constructors
- public SpriteMask()

#### Methods
- internal UnityEngine.Bounds GetSpriteBounds()
- private void GetSpriteBounds_Injected(out UnityEngine.Bounds ret)

### public static class UnityEngine.SpriteMaskUtility

#### Methods
- public static bool HasSpriteMaskInLayerRange(UnityEngine.Rendering.SortingLayerRange range)
- private static bool HasSpriteMaskInLayerRange_Injected(ref UnityEngine.Rendering.SortingLayerRange range)

