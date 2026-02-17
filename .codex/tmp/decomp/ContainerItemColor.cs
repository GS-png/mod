using System;
using UnityEngine;

[Serializable]
public class ContainerItemColor
{
	public string color_id;

	public Color color;

	private Material material;

	private string path_material;

	public ContainerItemColor(string pID, string pMaterialPath)
	{
		color = Toolbox.makeColor(pID);
		color_id = pID;
		path_material = pMaterialPath;
	}

	public Material getMaterial()
	{
		if (string.IsNullOrEmpty(path_material))
		{
			return null;
		}
		Material material = Resources.Load<Material>(path_material);
		this.material = material;
		return this.material;
	}
}
