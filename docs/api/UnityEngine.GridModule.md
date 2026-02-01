# Assembly: UnityEngine.GridModule
- Path: tools/WorldBox.Managed/UnityEngine.GridModule.dll
- Types: 4

## Namespace: UnityEngine

### public enum UnityEngine.GridLayout.CellLayout
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Hexagon = 1
- Isometric = 2
- IsometricZAsY = 3
- Rectangle = 0

### public enum UnityEngine.GridLayout.CellSwizzle
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- XYZ = 0
- XZY = 1
- YXZ = 2
- YZX = 3
- ZXY = 4
- ZYX = 5

### public class UnityEngine.Grid
- Base: UnityEngine.GridLayout

#### Properties
- public UnityEngine.Vector3 cellGap { get; set; }
- public UnityEngine.GridLayout.CellLayout cellLayout { get; set; }
- public UnityEngine.Vector3 cellSize { get; set; }
- public UnityEngine.GridLayout.CellSwizzle cellSwizzle { get; set; }

#### Constructors
- public Grid()

#### Methods
- public UnityEngine.Vector3 GetCellCenterLocal(UnityEngine.Vector3Int position)
- public UnityEngine.Vector3 GetCellCenterWorld(UnityEngine.Vector3Int position)
- public static UnityEngine.Vector3 InverseSwizzle(UnityEngine.GridLayout.CellSwizzle swizzle, UnityEngine.Vector3 position)
- private static void InverseSwizzle_Injected(UnityEngine.GridLayout.CellSwizzle swizzle, ref UnityEngine.Vector3 position, out UnityEngine.Vector3 ret)
- public static UnityEngine.Vector3 Swizzle(UnityEngine.GridLayout.CellSwizzle swizzle, UnityEngine.Vector3 position)
- private static void Swizzle_Injected(UnityEngine.GridLayout.CellSwizzle swizzle, ref UnityEngine.Vector3 position, out UnityEngine.Vector3 ret)

### public class UnityEngine.GridLayout
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.Vector3 cellGap { get; }
- public UnityEngine.GridLayout.CellLayout cellLayout { get; }
- public UnityEngine.Vector3 cellSize { get; }
- public UnityEngine.GridLayout.CellSwizzle cellSwizzle { get; }

#### Constructors
- public GridLayout()

#### Methods
- public UnityEngine.Vector3 CellToLocal(UnityEngine.Vector3Int cellPosition)
- public UnityEngine.Vector3 CellToLocalInterpolated(UnityEngine.Vector3 cellPosition)
- private void CellToLocalInterpolated_Injected(ref UnityEngine.Vector3 cellPosition, out UnityEngine.Vector3 ret)
- private void CellToLocal_Injected(ref UnityEngine.Vector3Int cellPosition, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 CellToWorld(UnityEngine.Vector3Int cellPosition)
- private void CellToWorld_Injected(ref UnityEngine.Vector3Int cellPosition, out UnityEngine.Vector3 ret)
- private void DoNothing()
- public UnityEngine.Bounds GetBoundsLocal(UnityEngine.Vector3Int cellPosition)
- public UnityEngine.Bounds GetBoundsLocal(UnityEngine.Vector3 origin, UnityEngine.Vector3 size)
- private UnityEngine.Bounds GetBoundsLocalOriginSize(UnityEngine.Vector3 origin, UnityEngine.Vector3 size)
- private void GetBoundsLocalOriginSize_Injected(ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 size, out UnityEngine.Bounds ret)
- private void GetBoundsLocal_Injected(ref UnityEngine.Vector3Int cellPosition, out UnityEngine.Bounds ret)
- public UnityEngine.Vector3 GetLayoutCellCenter()
- private void GetLayoutCellCenter_Injected(out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3Int LocalToCell(UnityEngine.Vector3 localPosition)
- public UnityEngine.Vector3 LocalToCellInterpolated(UnityEngine.Vector3 localPosition)
- private void LocalToCellInterpolated_Injected(ref UnityEngine.Vector3 localPosition, out UnityEngine.Vector3 ret)
- private void LocalToCell_Injected(ref UnityEngine.Vector3 localPosition, out UnityEngine.Vector3Int ret)
- public UnityEngine.Vector3 LocalToWorld(UnityEngine.Vector3 localPosition)
- private void LocalToWorld_Injected(ref UnityEngine.Vector3 localPosition, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3Int WorldToCell(UnityEngine.Vector3 worldPosition)
- private void WorldToCell_Injected(ref UnityEngine.Vector3 worldPosition, out UnityEngine.Vector3Int ret)
- public UnityEngine.Vector3 WorldToLocal(UnityEngine.Vector3 worldPosition)
- private void WorldToLocal_Injected(ref UnityEngine.Vector3 worldPosition, out UnityEngine.Vector3 ret)

