using UnityEngine;

public class ShadowEditor : MonoBehaviour
{
	public static ShadowEditor instance;

	public bool isEnabled;

	public Vector2 shadow_bound = new Vector2(0.5f, 0.14f);

	public float shadow_distortion = 0.08f;
}
