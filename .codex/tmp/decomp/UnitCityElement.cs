using System.Collections;
using UnityEngine;

public class UnitCityElement : UnitElement
{
	[SerializeField]
	private GameObject _title;

	[SerializeField]
	private CityListElement _city_element;

	protected override IEnumerator showContent()
	{
		if (actor.hasCity())
		{
			track_objects.Add(actor.getCity());
			_title.SetActive(value: true);
			_city_element.show(actor.getCity());
			_city_element.gameObject.SetActive(value: true);
		}
		yield break;
	}

	protected override void clear()
	{
		_title.SetActive(value: false);
		_city_element.gameObject.SetActive(value: false);
		base.clear();
	}

	public override bool checkRefreshWindow()
	{
		if (_city_element.gameObject.activeSelf && !actor.hasCity())
		{
			return true;
		}
		return base.checkRefreshWindow();
	}
}
