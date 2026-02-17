using System.Collections.Generic;
using UnityEngine;

public class DebugMessage : MonoBehaviour
{
	public GameObject prefab;

	public static bool log_enabled;

	public static DebugMessage instance;

	public List<DebugMessageFly> list;

	private List<DebugMessageFly> messagesToMove = new List<DebugMessageFly>();

	private void Start()
	{
		instance = this;
		list = new List<DebugMessageFly>();
	}

	public void moveAll(DebugMessageFly pMessage)
	{
		messagesToMove.Clear();
		foreach (DebugMessageFly item in list)
		{
			if (!(item == pMessage) && Toolbox.Dist(0f, item.transform.localPosition.y, 0f, pMessage.transform.localPosition.y) < 1f)
			{
				messagesToMove.Add(item);
			}
		}
		foreach (DebugMessageFly item2 in messagesToMove)
		{
			item2.moveUp();
		}
	}

	public DebugMessageFly getOldMessage(Transform pTransform)
	{
		foreach (DebugMessageFly item in list)
		{
			if (item.originTransform == pTransform)
			{
				return item;
			}
		}
		return null;
	}

	public static void log(Transform pTransofrm, string pMessage)
	{
		if (Debug.isDebugBuild && log_enabled)
		{
			DebugMessageFly oldMessage = instance.getOldMessage(pTransofrm);
			if (oldMessage != null)
			{
				oldMessage.addString(pMessage);
				return;
			}
			TextMesh component = Object.Instantiate(instance.prefab).gameObject.GetComponent<TextMesh>();
			component.gameObject.GetComponent<MeshRenderer>().sortingOrder = 100;
			component.transform.parent = instance.transform;
			DebugMessageFly component2 = component.GetComponent<DebugMessageFly>();
			component2.originTransform = pTransofrm;
			component2.addString(pMessage);
			instance.list.Add(component2);
		}
	}
}
