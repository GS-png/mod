using UnityEngine;
using UnityEngine.UI;

public class NerveImpulseElement : MonoBehaviour
{
	public Image image;

	private const float SPEED_MIN = 1f;

	private const float SPEED_MAX = 3f;

	private const float SCALE_MIN = 0.6f;

	private const float SCALE_MAX = 1f;

	private float _speed_current;

	private float _move_timer;

	public NeuronElement presynaptic_neuron;

	public NeuronElement postsynaptic_neuron;

	private Color _color_back = Toolbox.makeColor("#26A8A8", 0.5f);

	private Color _color_front = Toolbox.makeColor("#3AFFFF", 0.7f);

	public int wave;

	public void energize(NeuronElement pPresynapticNeuron, NeuronElement pPostsynapticNeuron, int pWave)
	{
		base.transform.localPosition = pPresynapticNeuron.transform.localPosition;
		presynaptic_neuron = pPresynapticNeuron;
		postsynaptic_neuron = pPostsynapticNeuron;
		_move_timer = 0f;
		_speed_current = Randy.randomFloat(1f, 3f);
		wave = pWave;
	}

	public ImpulseReachResult moveTowardsNextNeuron()
	{
		if (postsynaptic_neuron == null)
		{
			return ImpulseReachResult.Done;
		}
		_move_timer += _speed_current * Time.deltaTime;
		_move_timer = Mathf.Clamp01(_move_timer);
		Vector3 localPosition = presynaptic_neuron.transform.localPosition;
		Vector3 localPosition2 = postsynaptic_neuron.transform.localPosition;
		base.transform.localPosition = Vector3.Lerp(localPosition, localPosition2, _move_timer);
		updateImpulseColor();
		if (_move_timer >= 1f)
		{
			presynaptic_neuron = postsynaptic_neuron;
			postsynaptic_neuron = GetNextTargetNeuron();
			_move_timer = 0f;
			wave--;
			if (wave > 0)
			{
				return ImpulseReachResult.Split;
			}
			return ImpulseReachResult.Done;
		}
		return ImpulseReachResult.Move;
	}

	private NeuronElement GetNextTargetNeuron()
	{
		if (presynaptic_neuron.connected_neurons.Count == 0)
		{
			return null;
		}
		return presynaptic_neuron.connected_neurons.GetRandom();
	}

	private void updateImpulseColor()
	{
		float t = Mathf.Lerp(presynaptic_neuron.render_depth, postsynaptic_neuron.render_depth, _move_timer);
		Color color = Color.Lerp(_color_back, _color_front, t);
		if (image.color != color)
		{
			image.color = color;
		}
		float num = Mathf.Lerp(0.6f, 1f, t);
		if (base.transform.localScale.x != num)
		{
			base.transform.localScale = new Vector3(num, num, num);
		}
	}
}
