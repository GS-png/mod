using UnityEngine;

[RequireComponent(typeof(NameInput))]
public class PlayerNameInput : MonoBehaviour
{
	private NameInput _name_input;

	private void Awake()
	{
		_name_input = GetComponent<NameInput>();
		_name_input.addListener(inputAction);
	}

	private void Update()
	{
		_name_input.textField.color = World.world.getArchitectMood().getColorText();
	}

	private void OnEnable()
	{
		_name_input.setText(World.world.map_stats.player_name);
	}

	private void inputAction(string pInput)
	{
		World.world.map_stats.player_name = pInput;
	}
}
