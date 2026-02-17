using UnityEngine;

public class TextSortingLayer : MonoBehaviour
{
	private MeshRenderer meshRenderer;

	private void Start()
	{
		meshRenderer = base.gameObject.GetComponent<MeshRenderer>();
		meshRenderer.sortingLayerID = SortingLayer.NameToID("MapOverlay");
		meshRenderer.sortingOrder = 200;
	}
}
