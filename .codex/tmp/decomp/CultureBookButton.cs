using UnityEngine;
using UnityEngine.UI;

public class CultureBookButton : MonoBehaviour
{
	private Book _book;

	public Image cover;

	public Image icon;

	private bool _created;

	private void Start()
	{
		create();
	}

	private void create()
	{
		if (!_created)
		{
			_created = true;
			setupTooltip();
		}
	}

	public void setupTooltip()
	{
		if (TryGetComponent<TipButton>(out var component))
		{
			component.setHoverAction(showTooltip);
		}
	}

	internal void load(long pBookID)
	{
		Book pBook = World.world.books.get(pBookID);
		load(pBook);
	}

	internal void load(Book pBook)
	{
		_book = pBook;
		BookTypeAsset asset = _book.getAsset();
		string pPath = "books/book_icons/" + asset.path_icons + _book.data.path_icon;
		string pPath2 = "books/book_covers/" + _book.data.path_cover;
		Sprite sprite = SpriteTextureLoader.getSprite(pPath);
		Sprite sprite2 = SpriteTextureLoader.getSprite(pPath2);
		icon.sprite = sprite;
		cover.sprite = sprite2;
		base.gameObject.name = _book.getAsset().id;
	}

	private void showTooltip()
	{
		Tooltip.show(base.gameObject, "book", new TooltipData
		{
			book = _book
		});
	}
}
