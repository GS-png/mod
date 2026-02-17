public struct TabHistoryData
{
	public readonly MetaType meta_type;

	public readonly long id;

	public TabHistoryData(NanoObject pObject)
	{
		meta_type = pObject.getMetaType();
		id = pObject.id;
	}

	public NanoObject getNanoObject()
	{
		return AssetManager.meta_type_library.getAsset(meta_type).get(id);
	}
}
