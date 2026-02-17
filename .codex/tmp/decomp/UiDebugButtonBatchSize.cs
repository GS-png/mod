using UnityEngine;
using UnityEngine.UI;

public class UiDebugButtonBatchSize : MonoBehaviour
{
	[SerializeField]
	private Text _text;

	[SerializeField]
	private Button _button;

	private void Awake()
	{
		_button.onClick.AddListener(click);
	}

	public void click()
	{
		ParallelHelper.moveDebugBatchSize();
		updateText();
	}

	private void OnEnable()
	{
		updateText();
	}

	private void updateText()
	{
		_text.text = ParallelHelper.DEBUG_BATCH_SIZE.ToString();
	}
}
