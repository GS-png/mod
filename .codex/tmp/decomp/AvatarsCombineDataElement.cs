public struct AvatarsCombineDataElement
{
	public readonly int order_index;

	public readonly int total_amount;

	public AvatarsCombineDataElement(int pOrderIndex, int pTotalAmount)
	{
		order_index = pOrderIndex;
		total_amount = pTotalAmount;
	}
}
