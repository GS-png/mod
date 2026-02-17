using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public static class ButtonExtensions
{
	public static void TriggerHover(this Button button)
	{
		if (Input.mousePresent)
		{
			EventTrigger eventTrigger = button.gameObject.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = button.gameObject.AddComponent<EventTrigger>();
			}
			eventTrigger.OnPointerEnter(new PointerEventData(EventSystem.current));
		}
	}

	public static void OnHover(this Button button, UnityAction call)
	{
		if (Input.mousePresent)
		{
			EventTrigger eventTrigger = button.gameObject.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = button.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerEnter;
			entry.callback.AddListener(delegate
			{
				call();
			});
			eventTrigger.triggers.Add(entry);
		}
	}

	public static void OnHoverOut(this Button button, UnityAction call)
	{
		if (Input.mousePresent)
		{
			EventTrigger eventTrigger = button.gameObject.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = button.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerExit;
			entry.callback.AddListener(delegate
			{
				call();
			});
			eventTrigger.triggers.Add(entry);
		}
	}

	public static void OnHover(this Slider slider, UnityAction call)
	{
		if (Input.mousePresent)
		{
			EventTrigger eventTrigger = slider.gameObject.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = slider.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerEnter;
			entry.callback.AddListener(delegate
			{
				call();
			});
			eventTrigger.triggers.Add(entry);
		}
	}

	public static void OnHoverOut(this Slider slider, UnityAction call)
	{
		if (Input.mousePresent)
		{
			EventTrigger eventTrigger = slider.gameObject.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = slider.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerExit;
			entry.callback.AddListener(delegate
			{
				call();
			});
			eventTrigger.triggers.Add(entry);
		}
	}
}
