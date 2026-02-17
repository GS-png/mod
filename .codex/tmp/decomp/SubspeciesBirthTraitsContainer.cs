using System.Collections.Generic;
using UnityEngine;

public class SubspeciesBirthTraitsContainer : MonoBehaviour, ITraitsContainer<ActorTrait, ActorTraitButton>
{
	public IReadOnlyCollection<ActorTraitButton> getTraitButtons()
	{
		return (IReadOnlyCollection<ActorTraitButton>)(object)GetComponentsInChildren<ActorTraitButton>();
	}
}
