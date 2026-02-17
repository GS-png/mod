using System;
using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class NeuronsOverview : UnitElement, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private const float DRAGGING_SMOOTHING_TIME = 0.1f;

	private const float ROTATION_BOUNDS = 0.7f;

	private const float ROTATION_BOUNDS_MARGIN = 1.05f;

	private const float DRAG_SPEED = 0.46f;

	private const float DRAG_ROTATE_SPEED = 0.005f;

	private const float MIN_NEURON_CURSOR_DISTANCE = 40f;

	private const float RADIUS_NEURONS = 70f;

	private const float NEURON_SCALE_MIN = 0.8f;

	private const float NEURON_SCALE_MAX = 1.5f;

	private const float BASE_AXON_DISTANCE = 250f;

	private const float DISTANCE_SCALING_FACTOR = 1.5f;

	[SerializeField]
	private NeuronElement _prefab_neuron;

	[SerializeField]
	private NerveImpulseElement _prefab_nerve_impulse;

	[SerializeField]
	private AxonElement _prefab_axon;

	[SerializeField]
	private RectTransform _parent_axons;

	[SerializeField]
	private RectTransform _parent_nerve_impulses;

	[SerializeField]
	private RectTransform _parent_neurons;

	[SerializeField]
	private GameObject _mind_main;

	[SerializeField]
	private UnitTextManager _text_phrases;

	private ObjectPoolGenericMono<NeuronElement> _pool_neurons;

	private ObjectPoolGenericMono<NerveImpulseElement> _pool_impulses;

	private ObjectPoolGenericMono<AxonElement> _pool_axons;

	private List<NeuronElement> _neurons = new List<NeuronElement>();

	private NeuronElement _last_activated_neuron;

	private List<NerveImpulseElement> _active_impulses = new List<NerveImpulseElement>();

	private Color _color_neuron_disabled_front = Toolbox.makeColor("#111111");

	private Color _color_neuron_disabled_back = Toolbox.makeColor("#111111", 0.3f);

	private Color _color_neuron_back = Toolbox.makeColor("#A9A9A9", 0.3f);

	private Color _color_neuron_front = Toolbox.makeColor("#DDDDDD");

	private Color _color_axon_default = Toolbox.makeColor("#FFFFFF", 0.1f);

	private Color _color_axon_default_center = Toolbox.makeColor("#FF6666", 0.1f);

	private Color _color_light_axon = Toolbox.makeColor("#3AFFFF", 0.54f);

	private Color _neuron_highlighted = Toolbox.makeColor("#FFFFFF");

	private float _offset_target_x = -0.015f;

	private float _offset_target_y = 0.07f;

	private bool _is_dragging;

	private Vector2 _last_mouse_delta;

	private float _offset_x;

	private float _offset_y;

	private int _decision_counter;

	private DecisionAsset[] _decision_assets;

	public static NeuronsOverview instance;

	private NeuronElement _active_neuron;

	private NeuronElement _latest_touched_neuron;

	private bool _all_state = true;

	private void Start()
	{
		instance = this;
	}

	protected override void Awake()
	{
		base.Awake();
		_pool_neurons = new ObjectPoolGenericMono<NeuronElement>(_prefab_neuron, _parent_neurons);
		_pool_impulses = new ObjectPoolGenericMono<NerveImpulseElement>(_prefab_nerve_impulse, _parent_nerve_impulses);
		_pool_axons = new ObjectPoolGenericMono<AxonElement>(_prefab_axon, _parent_axons);
	}

	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
		eventData.useDragThreshold = false;
		_last_mouse_delta = Vector2.zero;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		_offset_x = (_offset_target_x = 0f);
		_offset_y = (_offset_target_y = 0f);
		clearHighlight();
		Tooltip.hideTooltipNow();
	}

	private void highlightAllAxons(float pLight)
	{
		foreach (AxonElement item in _pool_axons.getListTotal())
		{
			if (!(item.mod_light > pLight))
			{
				item.mod_light = pLight;
			}
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		_is_dragging = true;
		Vector2 delta = eventData.delta;
		if (delta.magnitude > _last_mouse_delta.magnitude)
		{
			highlightAllAxons(0.35f);
		}
		_last_mouse_delta = delta;
		_offset_x = (0f - delta.y) * 0.46f;
		_offset_y = delta.x * 0.46f;
		updateNeuronsVisual();
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		_is_dragging = false;
		Vector2 delta = eventData.delta;
		_offset_target_x += (0f - delta.y) * 0.005f;
		_offset_target_y += delta.x * 0.005f;
		if (Mathf.Abs(_offset_target_x) > 0.7f || Mathf.Abs(_offset_target_y) > 0.7f)
		{
			if (Mathf.Abs(_offset_target_x) > Mathf.Abs(_offset_target_y))
			{
				_offset_target_y = _offset_target_y / Mathf.Abs(_offset_target_x) * 0.7f;
			}
			else
			{
				_offset_target_x = _offset_target_x / Mathf.Abs(_offset_target_y) * 0.7f;
			}
		}
		_offset_target_x = Mathf.Clamp(_offset_target_x, -0.7f, 0.7f);
		_offset_target_y = Mathf.Clamp(_offset_target_y, -0.7f, 0.7f);
		highlightAllAxons(1f);
		fireImpulsesEverywhere();
	}

	private void fireImpulsesEverywhere()
	{
		for (int i = 0; i < _neurons.Count; i++)
		{
			NeuronElement pNeuron = _neurons[i];
			fireImpulseWaveFromHere(pNeuron, 2);
		}
	}

	private void highlightNeuron(NeuronElement pHighlighted = null)
	{
		foreach (NeuronElement neuron in _neurons)
		{
			if (!(neuron == pHighlighted) && neuron.highlighted)
			{
				neuron.highlighted = false;
				Tooltip.hideTooltipNow();
			}
		}
		pHighlighted?.setHighlighted();
	}

	private NeuronElement getClosestNeuronToCursor()
	{
		NeuronElement result = null;
		float num = float.MaxValue;
		Vector2 a = Input.mousePosition;
		foreach (NeuronElement neuron in _neurons)
		{
			Vector2 b = neuron.transform.position;
			float num2 = Vector2.Distance(a, b);
			if (!(num2 > 40f))
			{
				if (neuron == _active_neuron)
				{
					return neuron;
				}
				if (num2 < num)
				{
					num = num2;
					result = neuron;
				}
			}
		}
		return result;
	}

	private void prepareAxons()
	{
		int count = _neurons.Count;
		float num = 250f / Mathf.Sqrt(count) * 1.5f;
		for (int i = 0; i < _neurons.Count - 1; i++)
		{
			NeuronElement neuronElement = _neurons[i];
			if (neuronElement.isCenter())
			{
				continue;
			}
			for (int j = i + 1; j < _neurons.Count; j++)
			{
				NeuronElement neuronElement2 = _neurons[j];
				if (!neuronElement2.isCenter() && !(Vector3.Distance(neuronElement.transform.localPosition, neuronElement2.transform.localPosition) > num))
				{
					makeAxon(neuronElement, neuronElement2);
				}
			}
		}
	}

	private AxonElement makeAxon(NeuronElement pNeuron1, NeuronElement pNeuron2)
	{
		AxonElement next = _pool_axons.getNext();
		next.neuron_1 = pNeuron1;
		next.neuron_2 = pNeuron2;
		pNeuron1.addConnection(pNeuron2, next);
		pNeuron2.addConnection(pNeuron1, next);
		return next;
	}

	private void checkActorDecisions()
	{
		DecisionHelper.runSimulationForMindTab(actor);
		_decision_counter = DecisionHelper.decision_system.getCounter();
		_decision_assets = DecisionHelper.decision_system.getActions();
	}

	private void updateNeuronsVisual()
	{
		Quaternion quaternion = Quaternion.Euler(_offset_x, _offset_y, 0f);
		foreach (NeuronElement neuron in _neurons)
		{
			neuron.updateColorsAndTooltip();
			Vector3 localPosition = quaternion * neuron.transform.localPosition;
			neuron.transform.localPosition = localPosition;
			calculateNeuronDepth(neuron, 70f);
			updateNeuronColorAndScale(neuron);
		}
		sortNeuronsByDepth();
	}

	private void updateNeuronImpulseAutoSpawn()
	{
		foreach (NeuronElement neuron in _neurons)
		{
			neuron.updateSpawnTimer();
		}
	}

	private void sortNeuronsByDepth()
	{
		foreach (NeuronElement neuron in _neurons)
		{
			neuron.transform.SetAsLastSibling();
		}
		_neurons.Sort((NeuronElement a, NeuronElement b) => a.render_depth.CompareTo(b.render_depth));
	}

	private void calculateNeuronDepth(NeuronElement pNeuronElement, float pRadius)
	{
		float z = pNeuronElement.transform.localPosition.z;
		float render_depth = Mathf.InverseLerp(0f - pRadius, pRadius, z);
		pNeuronElement.render_depth = render_depth;
	}

	private void updateNeuronColorAndScale(NeuronElement pElement)
	{
		if (!pElement.isDecisionEnabled())
		{
			Color color = Color.Lerp(_color_neuron_disabled_back, _color_neuron_disabled_front, pElement.render_depth);
			pElement.setColor(color);
		}
		else if (pElement.highlighted)
		{
			Color color2 = Color.Lerp(_color_neuron_back, _neuron_highlighted, pElement.render_depth);
			pElement.setColor(color2);
		}
		else
		{
			Color color3 = Color.Lerp(_color_neuron_back, _color_neuron_front, pElement.render_depth);
			pElement.setColor(color3);
		}
		float num = Mathf.Lerp(0.8f, 1.5f, pElement.render_depth);
		num *= pElement.scale_mod_spawn * pElement.bonus_scale;
		pElement.transform.localScale = new Vector3(num, num, num);
	}

	private void updateAxonPositions()
	{
		foreach (AxonElement item in _pool_axons.getListTotal())
		{
			item.update();
			float y = 1f;
			NeuronElement neuron_ = item.neuron_1;
			NeuronElement neuron_2 = item.neuron_2;
			if (neuron_.highlighted || neuron_2.highlighted)
			{
				y = 6f;
			}
			Color color = _color_axon_default;
			if (item.axon_center)
			{
				color = _color_axon_default_center;
				y = 7f;
			}
			if (item.mod_light > 0f)
			{
				Color color2 = Color.Lerp(color, _color_light_axon, item.mod_light);
				item.image.color = color2;
			}
			else
			{
				item.image.color = color;
			}
			Vector2 vector = neuron_.transform.localPosition;
			Vector2 vector2 = neuron_2.transform.localPosition;
			Vector2 vector3 = (vector + vector2) / 2f;
			item.transform.localPosition = vector3;
			float x = Vector3.Distance(vector, vector2);
			item.transform.localScale = new Vector3(x, y, 1f);
			Vector3 vector4 = vector2 - vector;
			float z = Mathf.Atan2(vector4.y, vector4.x) * 57.29578f;
			item.transform.rotation = Quaternion.Euler(0f, 0f, z);
		}
	}

	private void smoothOffsets()
	{
		_offset_x = Mathf.Lerp(_offset_x, _offset_target_x, 0.1f);
		_offset_y = Mathf.Lerp(_offset_y, _offset_target_y, 0.1f);
	}

	internal void fireImpulseWaveFromHere(NeuronElement pNeuron, int pWaves = 4)
	{
		if (!pNeuron.isDecisionEnabled())
		{
			return;
		}
		foreach (NeuronElement connected_neuron in pNeuron.connected_neurons)
		{
			if (connected_neuron.isDecisionEnabled())
			{
				fireImpulse(pNeuron, connected_neuron, pWaves);
			}
		}
	}

	private void fireImpulseFrom(NeuronElement pPresynapticNeuron, int pWave, NeuronElement pIgnoreNeuron = null)
	{
		if (pPresynapticNeuron.connected_neurons.Count == 0)
		{
			return;
		}
		NeuronElement random;
		if (pIgnoreNeuron == null)
		{
			random = pPresynapticNeuron.connected_neurons.GetRandom();
		}
		else
		{
			using ListPool<NeuronElement> listPool = new ListPool<NeuronElement>();
			foreach (NeuronElement connected_neuron in pPresynapticNeuron.connected_neurons)
			{
				if (!(pIgnoreNeuron == connected_neuron))
				{
					listPool.Add(connected_neuron);
				}
			}
			if (listPool.Count == 0)
			{
				return;
			}
			random = listPool.GetRandom();
		}
		if (!(random == null))
		{
			fireImpulse(pPresynapticNeuron, random, pWave);
		}
	}

	internal void fireImpulse(NeuronElement pPresynapticNeuron, NeuronElement pPostsynapticNeuron, int pWave)
	{
		NerveImpulseElement next = _pool_impulses.getNext();
		next.energize(pPresynapticNeuron, pPostsynapticNeuron, pWave);
		pPresynapticNeuron.spawnImpulseFromHere();
		_active_impulses.Add(next);
	}

	private void updateImpulses()
	{
		for (int num = _active_impulses.Count - 1; num >= 0; num--)
		{
			NerveImpulseElement nerveImpulseElement = _active_impulses[num];
			ImpulseReachResult impulseReachResult = nerveImpulseElement.moveTowardsNextNeuron();
			NeuronElement postsynaptic_neuron = nerveImpulseElement.postsynaptic_neuron;
			NeuronElement presynaptic_neuron = nerveImpulseElement.presynaptic_neuron;
			switch (impulseReachResult)
			{
			case ImpulseReachResult.Done:
				postsynaptic_neuron?.receiveImpulse();
				_active_impulses.RemoveAt(num);
				_pool_impulses.release(nerveImpulseElement);
				break;
			case ImpulseReachResult.Split:
				postsynaptic_neuron?.receiveImpulse();
				fireImpulseFrom(postsynaptic_neuron, nerveImpulseElement.wave, presynaptic_neuron);
				break;
			}
		}
	}

	private void Update()
	{
		if (!_is_dragging)
		{
			smoothOffsets();
			if (InputHelpers.mouseSupported)
			{
				_active_neuron = getHighlightedNeuron();
				highlightNeuron(_active_neuron);
			}
			if (InputHelpers.mouseSupported || _latest_touched_neuron == null || !Tooltip.isShowingFor(_latest_touched_neuron))
			{
				updateNeuronsVisual();
			}
		}
		updateNeuronImpulseAutoSpawn();
		updateAxonPositions();
		updateImpulseSpawn();
		updateImpulses();
	}

	private NeuronElement getHighlightedNeuron()
	{
		if (_is_dragging)
		{
			return null;
		}
		if (_offset_x > 1.05f || _offset_x < -1.05f)
		{
			return null;
		}
		if (_offset_y > 1.05f || _offset_y < -1.05f)
		{
			return null;
		}
		return getClosestNeuronToCursor();
	}

	internal void startNewWhat()
	{
		_text_phrases.startNewWhat();
	}

	private void updateImpulseSpawn()
	{
		foreach (NeuronElement neuron in _neurons)
		{
			if (neuron.hasDecisionSet() && neuron.readyToSpawnImpulse())
			{
				fireImpulseFrom(neuron, 1);
			}
		}
	}

	private void initStartPositions()
	{
		for (int i = 0; i < _decision_counter; i++)
		{
			DecisionAsset pAsset = _decision_assets[i];
			NeuronElement next = _pool_neurons.getNext();
			next.setupDecisionAndActor(pAsset, actor);
			Vector3 positionOnSphere = getPositionOnSphere(i, _decision_counter);
			next.transform.localPosition = positionOnSphere;
			_neurons.Add(next);
		}
		updateNeuronsVisual();
	}

	private void loadLastDecisionForCenter()
	{
		NeuronElement neuronElement = null;
		string lastDecisionForMindOverview = actor.getLastDecisionForMindOverview();
		if (!string.IsNullOrEmpty(lastDecisionForMindOverview))
		{
			foreach (NeuronElement neuron in _neurons)
			{
				if (neuron.decision.id == lastDecisionForMindOverview)
				{
					neuronElement = neuron;
					break;
				}
			}
		}
		_last_activated_neuron = _pool_neurons.getNext();
		_last_activated_neuron.transform.localPosition = Vector3.zero;
		_last_activated_neuron.image.sprite = SpriteTextureLoader.getSprite("ui/icons/iconBrain");
		_last_activated_neuron.bonus_scale = 1.5f;
		_last_activated_neuron.setCenter(pState: true);
		_last_activated_neuron.actor = actor;
		_neurons.Add(_last_activated_neuron);
		if (neuronElement != null)
		{
			makeAxon(neuronElement, _last_activated_neuron).axon_center = true;
		}
	}

	private Vector3 getPositionOnSphere(int pNeuronIndex, int pTotalNeurons)
	{
		float f = Mathf.Acos(1f - (float)(2 * (pNeuronIndex + 1)) / (float)pTotalNeurons);
		float f2 = MathF.PI * (1f + Mathf.Sqrt(5f)) * (float)pNeuronIndex;
		float x = 70f * Mathf.Cos(f2) * Mathf.Sin(f);
		float y = 70f * Mathf.Sin(f2) * Mathf.Sin(f);
		float z = 70f * Mathf.Cos(f);
		return new Vector3(x, y, z);
	}

	private void clearMind()
	{
		foreach (NeuronElement neuron in _neurons)
		{
			neuron.clear();
		}
		_active_impulses.Clear();
		_pool_axons.clear();
		_pool_neurons.clear();
		_pool_impulses.clear();
		_neurons.Clear();
		foreach (AxonElement item in _pool_axons.getListTotal())
		{
			item.clear();
		}
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		_mind_main.transform.DOKill();
		_mind_main.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		_mind_main.transform.DOScale(1f, 0.6f).SetEase(Ease.OutBack);
		checkActorDecisions();
		clearMind();
		initStartPositions();
		loadLastDecisionForCenter();
		prepareAxons();
		_is_dragging = false;
	}

	internal bool isDragging()
	{
		return _is_dragging;
	}

	internal void clearHighlight()
	{
		if (!(_active_neuron == null))
		{
			_active_neuron.highlighted = false;
			_active_neuron = null;
		}
	}

	public static void debugTool(DebugTool pTool)
	{
		instance?.debug(pTool);
	}

	public void debug(DebugTool pTool)
	{
		pTool.setText("offset_target_x:", getFloat(_offset_target_x), 0f, pShowBar: false, 0L);
		pTool.setText("offset_target_y:", getFloat(_offset_target_y), 0f, pShowBar: false, 0L);
		pTool.setSeparator();
		pTool.setText("offset_x:", getFloat(_offset_x), 0f, pShowBar: false, 0L);
		pTool.setText("offset_y:", getFloat(_offset_y), 0f, pShowBar: false, 0L);
		pTool.setSeparator();
		Quaternion quaternion = Quaternion.Euler(_offset_x, _offset_y, 0f);
		pTool.setText("combined_rotation.x:", getFloat(quaternion.x), 0f, pShowBar: false, 0L);
		pTool.setText("combined_rotation.y:", getFloat(quaternion.y), 0f, pShowBar: false, 0L);
		pTool.setText("combined_rotation.z:", getFloat(quaternion.z), 0f, pShowBar: false, 0L);
		pTool.setText("combined_rotation.w:", getFloat(quaternion.w), 0f, pShowBar: false, 0L);
		pTool.setSeparator();
		pTool.setText("is_dragging:", _is_dragging, 0f, pShowBar: false, 0L);
		pTool.setText("last_mouse_delta:", _last_mouse_delta, 0f, pShowBar: false, 0L);
		pTool.setSeparator();
		pTool.setText("decisions:", _decision_counter, 0f, pShowBar: false, 0L);
		pTool.setSeparator();
		pTool.setText("neuron selected:", _active_neuron, 0f, pShowBar: false, 0L);
	}

	public static string getFloat(float pFloat)
	{
		if (pFloat < 0.001f && pFloat > -0.001f)
		{
			return pFloat.ToString("F6", CultureInfo.InvariantCulture);
		}
		if (pFloat > 0f)
		{
			return "<color=#75D53A>" + pFloat.ToString("F6", CultureInfo.InvariantCulture) + "</color>";
		}
		return "<color=#DB2920>" + pFloat.ToString("F6", CultureInfo.InvariantCulture) + "</color>";
	}

	public void setLatestTouched(NeuronElement pNeuron)
	{
		_latest_touched_neuron = pNeuron;
	}

	public void switchAllNeurons()
	{
		if (!isAnyEnabled())
		{
			_all_state = true;
		}
		else if (isAllEnabled())
		{
			_all_state = false;
		}
		else
		{
			_all_state = !_all_state;
		}
		foreach (NeuronElement neuron in _neurons)
		{
			if (neuron.hasDecisionSet())
			{
				actor.setDecisionState(neuron.decision.decision_index, _all_state);
			}
		}
		fireImpulsesEverywhere();
	}

	public bool getAllState()
	{
		return _all_state;
	}

	private bool isAnyEnabled()
	{
		foreach (NeuronElement neuron in _neurons)
		{
			if (neuron.hasDecisionSet() && actor.isDecisionEnabled(neuron.decision.decision_index))
			{
				return true;
			}
		}
		return false;
	}

	private bool isAllEnabled()
	{
		foreach (NeuronElement neuron in _neurons)
		{
			if (neuron.hasDecisionSet() && !actor.isDecisionEnabled(neuron.decision.decision_index))
			{
				return false;
			}
		}
		return true;
	}
}
