using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeOverview : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	[SerializeField]
	private DragSnapElement _knob_perspective_strength_x;

	[SerializeField]
	private DragSnapElement _knob_perspective_strength_y;

	[SerializeField]
	private DragSnapElement _knob_perspective_strength_z;

	[SerializeField]
	private DragSnapElement _knob_perspective_strength_main;

	[SerializeField]
	private DragSnapElement _knob_warp;

	[SerializeField]
	private DragSnapElement _knob_lense;

	[SerializeField]
	private DragSnapElement _knob_spacing;

	[SerializeField]
	private DragSnapElement _knob_speed_outer;

	[SerializeField]
	private DragSnapElement _knob_speed_inner;

	[SerializeField]
	private DragSnapElement _knob_speed_4d;

	[SerializeField]
	private DragSnapElement _knob_icon_size;

	[SerializeField]
	private DragSnapElement _knob_connection_size;

	[SerializeField]
	private DragSnapElement _knob_reset;

	private CubeNode _active_node;

	[SerializeField]
	private CubeNode _prefab_node;

	[SerializeField]
	private CubeNodeConnection _prefab_connection;

	[SerializeField]
	private RectTransform _parent_connections;

	[SerializeField]
	private RectTransform _parent_nodes;

	[SerializeField]
	private GameObject _object_main;

	private float _offset_target_x = -0.015f;

	private float _offset_target_y = 0.07f;

	private bool _is_dragging;

	private Vector2 _last_mouse_delta;

	private float _offset_x;

	private float _offset_y;

	internal bool highlighted;

	private List<CubeNode> _nodes_by_index = new List<CubeNode>();

	private List<CubeNode> _nodes = new List<CubeNode>();

	private ObjectPoolGenericMono<CubeNode> _pool_nodes;

	private ObjectPoolGenericMono<CubeNodeConnection> _pool_connections;

	private Quaternion _rotation_q = Quaternion.identity;

	private Quaternion _rotation_q_2 = Quaternion.identity;

	private List<CubeNodeAssetData> _all_available_assets = new List<CubeNodeAssetData>();

	private CubeNode _latest_touched_node;

	private KnowledgeAsset _filter_asset;

	private float _angle_4d;

	private const float DRAGGING_SMOOTHING_TIME = 0.1f;

	private const float ROTATION_BOUNDS = 0.7f;

	private const float ROTATION_BOUNDS_MARGIN = 1.05f;

	private const float DRAG_SPEED = 0.46f;

	private const float DRAG_ROTATE_SPEED = 0.005f;

	private const float MIN_NODE_CURSOR_DISTANCE = 40f;

	public float RADIUS_NODE_PLACEMENT = 30f;

	private const float NODE_SCALE_MIN = 0.4f;

	private const float NODE_SCALE_MAX = 1.2f;

	private Color _color_node_back = Toolbox.makeColor("#1D7A74");

	private Color _color_node_front = Toolbox.makeColor("#DDDDDD");

	private Color _node_highlighted = Toolbox.makeColor("#FFFFFF");

	private Color _color_connection_back = Toolbox.makeColor("#1D7A74", 0.5f);

	private Color _color_connection_default = Toolbox.makeColor("#3AFFF5", 1f);

	private const float PERSPECTIVE_STRENGTH_MAIN = 3f;

	private const float PERSPECTIVE_STRENGTH_MAIN_MOD = 1f;

	private const float PERSPECTIVE_STRENGTH_AXIS = 1f;

	private const float SPACING_MOD = 1f;

	private const float SPEED_MOD_OUTER = 0.2f;

	private const float SPEED_MOD_INNER = 0.2f;

	private const float SPEED_MOD_4D = 0.3f;

	private const float MOD_NODE_SIZE = 1f;

	private const float MOD_CONNECTION_SIZE = 1f;

	private const float WARP_MOD = 0f;

	private const float LENSE_MOD = 0f;

	private const float FOLD_MOD = 0f;

	private float _perspective_strength_main_mod = 1f;

	private float _perspective_strength_main = 3f;

	private float _perspective_strength_x = 1f;

	private float _perspective_strength_y = 1f;

	private float _perspective_strength_z = 1f;

	private float _mod_lense;

	private float _mod_warp;

	private float _spacing_mod = 1f;

	private float _speed_mod_inner = 0.2f;

	private float _speed_mod_outer = 0.2f;

	private float _speed_mod_4d = 0.3f;

	private float _mod_node_size = 1f;

	private float _mod_connection_size = 1f;

	public float spacing = 25f;

	private static readonly Vector4[] _hypercube_positions = new Vector4[16]
	{
		new Vector4(-1f, -1f, -1f, -1f),
		new Vector4(1f, -1f, -1f, -1f),
		new Vector4(-1f, 1f, -1f, -1f),
		new Vector4(1f, 1f, -1f, -1f),
		new Vector4(-1f, -1f, 1f, -1f),
		new Vector4(1f, -1f, 1f, -1f),
		new Vector4(-1f, 1f, 1f, -1f),
		new Vector4(1f, 1f, 1f, -1f),
		new Vector4(-1f, -1f, -1f, 1f),
		new Vector4(1f, -1f, -1f, 1f),
		new Vector4(-1f, 1f, -1f, 1f),
		new Vector4(1f, 1f, -1f, 1f),
		new Vector4(-1f, -1f, 1f, 1f),
		new Vector4(1f, -1f, 1f, 1f),
		new Vector4(-1f, 1f, 1f, 1f),
		new Vector4(1f, 1f, 1f, 1f)
	};

	private static readonly int[,] _hypercube_connections = new int[32, 2]
	{
		{ 0, 1 },
		{ 0, 2 },
		{ 0, 4 },
		{ 0, 8 },
		{ 1, 3 },
		{ 1, 5 },
		{ 1, 9 },
		{ 2, 3 },
		{ 2, 6 },
		{ 2, 10 },
		{ 3, 7 },
		{ 3, 11 },
		{ 4, 5 },
		{ 4, 6 },
		{ 4, 12 },
		{ 5, 7 },
		{ 5, 13 },
		{ 6, 7 },
		{ 6, 14 },
		{ 7, 15 },
		{ 8, 9 },
		{ 8, 10 },
		{ 8, 12 },
		{ 9, 11 },
		{ 9, 13 },
		{ 10, 11 },
		{ 10, 14 },
		{ 11, 15 },
		{ 12, 13 },
		{ 12, 14 },
		{ 13, 15 },
		{ 14, 15 }
	};

	protected void Awake()
	{
		_pool_nodes = new ObjectPoolGenericMono<CubeNode>(_prefab_node, _parent_nodes);
		_pool_connections = new ObjectPoolGenericMono<CubeNodeConnection>(_prefab_connection, _parent_connections);
	}

	private void initStartPositions()
	{
		for (int i = 0; i < _hypercube_positions.Length; i++)
		{
			CubeNodeAssetData random = _all_available_assets.GetRandom();
			CubeNode next = _pool_nodes.getNext();
			next.setupAsset(random);
			next.logical_pos = _hypercube_positions[i];
			next.setDebugText(i.ToString() ?? "");
			next.gameObject.name = i.ToString();
			_nodes.Add(next);
			_nodes_by_index.Add(next);
		}
		updateNodesVisual();
	}

	private void prepareConnections()
	{
		for (int i = 0; i < _hypercube_connections.GetLength(0); i++)
		{
			int index = _hypercube_connections[i, 0];
			int index2 = _hypercube_connections[i, 1];
			CubeNode pNode = _nodes_by_index[index];
			CubeNode pNode2 = _nodes_by_index[index2];
			makeConnection(pNode, pNode2);
		}
	}

	private Vector3 project4Dto3D(Vector4 p)
	{
		float num = _perspective_strength_main * _perspective_strength_main_mod;
		float num2 = Mathf.Exp((0f - Mathf.Abs(p.w)) * _mod_lense);
		float num3 = p.w;
		float num4 = Mathf.Sin(num3 * _mod_warp);
		if (_mod_warp > 0f)
		{
			num3 = num4;
		}
		float num5 = num - num3;
		if (Mathf.Abs(num5) < 0.01f)
		{
			num5 = 0.01f * Mathf.Sign(num5);
		}
		float num6 = ((num5 == 0f) ? 0f : (num / num5));
		num6 *= num2;
		return new Vector3(p.x * num6 * _perspective_strength_x, p.y * num6 * _perspective_strength_y, p.z * num6 * _perspective_strength_z);
	}

	private void updateRotationAndSpeeds()
	{
		if (!_is_dragging)
		{
			_angle_4d += Time.deltaTime * _speed_mod_4d;
		}
		if (Input.GetMouseButton(0))
		{
			_perspective_strength_main = Mathf.Lerp(_perspective_strength_main, 4f, 0.1f);
		}
		else
		{
			_perspective_strength_main = Mathf.Lerp(_perspective_strength_main, 3f, 0.1f);
		}
		float num = 0f - _offset_x;
		float num2 = 0f - _offset_y;
		float num3 = _offset_y;
		float num4 = _offset_y;
		if (!_is_dragging)
		{
			num += _speed_mod_inner;
			num2 += _speed_mod_inner;
			num3 += _speed_mod_outer;
			num4 += _speed_mod_outer;
		}
		Quaternion quaternion = Quaternion.Euler(num, num2, 0f);
		_rotation_q = quaternion * _rotation_q;
		Quaternion quaternion2 = Quaternion.Euler(num3, num4, 0f);
		_rotation_q_2 = quaternion2 * _rotation_q_2;
	}

	private void updateNodesVisual()
	{
		float angle_4d = _angle_4d;
		foreach (CubeNode node in _nodes)
		{
			bool num = node.logical_pos.w < 0f;
			float num2 = spacing * _spacing_mod;
			Vector4 p = rotate4D(node.logical_pos, angle_4d);
			Vector3 vector = project4Dto3D(p) * num2;
			Vector3 localPosition = (num ? _rotation_q : _rotation_q_2) * vector;
			node.transform.localPosition = localPosition;
			calculateNodeDepth(node, RADIUS_NODE_PLACEMENT);
			updateNodeColorAndScale(node);
		}
		sortNodesByDepth();
	}

	private Vector4 rotate4D(Vector4 pPoint, float pAngle)
	{
		float num = Mathf.Cos(pAngle);
		float num2 = Mathf.Sin(pAngle);
		float x = pPoint.x * num - pPoint.w * num2;
		float w = pPoint.x * num2 + pPoint.w * num;
		float y = pPoint.y * num - pPoint.z * num2;
		float z = pPoint.y * num2 + pPoint.z * num;
		return new Vector4(x, y, z, w);
	}

	protected void OnEnable()
	{
		_object_main.transform.DOKill();
		_object_main.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		_object_main.transform.DOScale(1f, 0.6f).SetEase(Ease.OutBack);
		fillAssets();
		clearContent();
		initStartPositions();
		prepareConnections();
		_is_dragging = false;
	}

	private CubeNodeConnection makeConnection(CubeNode pNode1, CubeNode pNode2)
	{
		CubeNodeConnection next = _pool_connections.getNext();
		next.node_1 = pNode1;
		next.node_2 = pNode2;
		pNode1.addConnection(pNode2, next);
		pNode2.addConnection(pNode1, next);
		if (pNode1.logical_pos.w < 0f && pNode2.logical_pos.w < 0f)
		{
			next.setConnection(pInner: true);
		}
		else
		{
			next.setConnection(pInner: false);
		}
		next.gameObject.name = "connection " + pNode1.gameObject.name + "-" + pNode2.gameObject.name;
		return next;
	}

	private void fillAssets()
	{
		_all_available_assets.Clear();
		if (_filter_asset != null)
		{
			loadUnlockables(_filter_asset.get_library(), _filter_asset.id);
			_filter_asset = null;
			return;
		}
		loadUnlockables(AssetManager.actor_library, "units");
		loadUnlockables(AssetManager.items, "items");
		loadUnlockables(AssetManager.gene_library, "genes");
		loadUnlockables(AssetManager.traits, "traits");
		loadUnlockables(AssetManager.subspecies_traits, "subspecies_traits");
		loadUnlockables(AssetManager.culture_traits, "culture_traits");
		loadUnlockables(AssetManager.language_traits, "language_traits");
		loadUnlockables(AssetManager.clan_traits, "clan_traits");
		loadUnlockables(AssetManager.religion_traits, "religion_traits");
		loadUnlockables(AssetManager.kingdoms_traits, "kingdom_traits");
		loadUnlockables(AssetManager.plots_library, "plots");
	}

	private void loadUnlockables(ILibraryWithUnlockables pLibrary, string pType)
	{
		foreach (BaseUnlockableAsset item in pLibrary.elements_list)
		{
			if (item.show_in_knowledge_window && !item.isTemplateAsset())
			{
				_all_available_assets.Add(new CubeNodeAssetData(item, pType));
			}
		}
	}

	private void Update()
	{
		if (InputHelpers.mouseSupported || _latest_touched_node == null || !Tooltip.isShowingFor(_latest_touched_node.transform))
		{
			updateRotationAndSpeeds();
		}
		foreach (CubeNode node in _nodes)
		{
			node.update();
		}
		if (!_is_dragging)
		{
			smoothOffsets();
			_active_node = getHighlightedNode();
			highlightNode(_active_node);
		}
		updateNodesVisual();
		updateConnectionPositions();
		updateKnobs();
	}

	private void updateKnobs()
	{
		float num = 0.05f;
		if (_knob_perspective_strength_main != null)
		{
			float num2 = _knob_perspective_strength_main.getDragMod() * 0.03f;
			_perspective_strength_main_mod += num2 * num;
			_perspective_strength_main_mod = Mathf.Clamp(_perspective_strength_main_mod, 0.1f, 1f);
		}
		if (_knob_perspective_strength_x != null)
		{
			float dragMod = _knob_perspective_strength_x.getDragMod();
			_perspective_strength_x += dragMod * num;
			_perspective_strength_x = Mathf.Clamp(_perspective_strength_x, 0f, 2f);
		}
		if (_knob_perspective_strength_y != null)
		{
			float dragMod2 = _knob_perspective_strength_y.getDragMod();
			_perspective_strength_y += dragMod2 * num;
			_perspective_strength_y = Mathf.Clamp(_perspective_strength_y, 0f, 2f);
		}
		if (_knob_perspective_strength_z != null)
		{
			float dragMod3 = _knob_perspective_strength_z.getDragMod();
			_perspective_strength_z += dragMod3 * num;
			_perspective_strength_z = Mathf.Clamp(_perspective_strength_z, 0f, 2f);
		}
		if (_knob_spacing != null)
		{
			float dragMod4 = _knob_spacing.getDragMod();
			_spacing_mod += dragMod4 * num;
			_spacing_mod = Mathf.Clamp(_spacing_mod, 0f, 3f);
		}
		if (_knob_warp != null)
		{
			float dragMod5 = _knob_warp.getDragMod();
			_mod_warp += dragMod5 * num;
			_mod_warp = Mathf.Clamp(_mod_warp, 0f, 10f);
		}
		if (_knob_lense != null)
		{
			float dragMod6 = _knob_lense.getDragMod();
			_mod_lense += dragMod6 * num;
			_mod_lense = Mathf.Clamp(_mod_lense, 0f, 2f);
		}
		if (_knob_speed_outer != null)
		{
			float dragMod7 = _knob_speed_outer.getDragMod();
			_speed_mod_outer += dragMod7 * num;
			_speed_mod_outer = Mathf.Clamp(_speed_mod_outer, 0f, 20f);
		}
		if (_knob_speed_inner != null)
		{
			float dragMod8 = _knob_speed_inner.getDragMod();
			_speed_mod_inner += dragMod8 * num;
			_speed_mod_inner = Mathf.Clamp(_speed_mod_inner, 0f, 20f);
		}
		if (_knob_connection_size != null)
		{
			float dragMod9 = _knob_connection_size.getDragMod();
			_mod_connection_size += dragMod9 * num;
			_mod_connection_size = Mathf.Clamp(_mod_connection_size, 0f, 10f);
		}
		if (_knob_icon_size != null)
		{
			float dragMod10 = _knob_icon_size.getDragMod();
			_mod_node_size += dragMod10 * num;
			_mod_node_size = Mathf.Clamp(_mod_node_size, 0f, 20f);
		}
		if (_knob_speed_4d != null)
		{
			float dragMod11 = _knob_speed_4d.getDragMod();
			_speed_mod_4d += dragMod11 * num;
			_speed_mod_4d = Mathf.Clamp(_speed_mod_4d, 0f, 20f);
		}
		if (_knob_reset != null)
		{
			float dragMod12 = _knob_reset.getDragMod();
			dragMod12 = Math.Abs(dragMod12);
			_perspective_strength_main = Mathf.Lerp(_perspective_strength_main, 3f, dragMod12 * num);
			_perspective_strength_x = Mathf.Lerp(_perspective_strength_x, 1f, dragMod12 * num);
			_perspective_strength_y = Mathf.Lerp(_perspective_strength_y, 1f, dragMod12 * num);
			_perspective_strength_z = Mathf.Lerp(_perspective_strength_z, 1f, dragMod12 * num);
			_spacing_mod = Mathf.Lerp(_spacing_mod, 1f, dragMod12 * num);
			_speed_mod_outer = Mathf.Lerp(_speed_mod_outer, 0.2f, dragMod12 * num);
			_speed_mod_inner = Mathf.Lerp(_speed_mod_inner, 0.2f, dragMod12 * num);
			_speed_mod_4d = Mathf.Lerp(_speed_mod_4d, 0.3f, dragMod12 * num);
			_mod_connection_size = Mathf.Lerp(_mod_connection_size, 1f, dragMod12 * num);
			_mod_node_size = Mathf.Lerp(_mod_node_size, 1f, dragMod12 * num);
			_perspective_strength_main_mod = Mathf.Lerp(_perspective_strength_main_mod, 1f, dragMod12 * num);
			_mod_warp = Mathf.Lerp(_mod_warp, 0f, dragMod12 * num);
			_mod_lense = Mathf.Lerp(_mod_lense, 0f, dragMod12 * num);
		}
	}

	private void updateConnectionPositions()
	{
		foreach (CubeNodeConnection item in _pool_connections.getListTotal())
		{
			item.update();
			float num = 1f;
			CubeNode node_ = item.node_1;
			CubeNode node_2 = item.node_2;
			if (item.inner_cube)
			{
				num = 3f;
			}
			if (node_.highlighted || node_2.highlighted)
			{
				num = 6f;
			}
			num *= _mod_connection_size;
			Color color = Color.Lerp(t: (!(node_.render_depth > node_2.render_depth)) ? node_2.render_depth : node_.render_depth, a: _color_connection_back, b: _color_connection_default);
			item.image.color = color;
			Vector2 vector = node_.transform.localPosition;
			Vector2 vector2 = node_2.transform.localPosition;
			Vector2 vector3 = (vector + vector2) / 2f;
			item.transform.localPosition = vector3;
			float x = Vector3.Distance(vector, vector2);
			item.transform.localScale = new Vector3(x, num, 1f);
			Vector3 vector4 = vector2 - vector;
			float z = Mathf.Atan2(vector4.y, vector4.x) * 57.29578f;
			item.transform.rotation = Quaternion.Euler(0f, 0f, z);
		}
	}

	public CubeNodeAssetData getRandom()
	{
		return _all_available_assets.GetRandom();
	}

	public void setLatestTouched(CubeNode pNode)
	{
		_latest_touched_node = pNode;
	}

	public void setFilterAsset(KnowledgeAsset pAsset)
	{
		_filter_asset = pAsset;
	}

	private void highlightAllConnectonsFromDrag(float pLight)
	{
		foreach (CubeNodeConnection item in _pool_connections.getListTotal())
		{
			if (!(item.mod_light > pLight))
			{
				item.mod_light = pLight;
			}
		}
	}

	private void highlightNode(CubeNode pHighlighted = null)
	{
		foreach (CubeNode node in _nodes)
		{
			if (!(node == pHighlighted) && node.highlighted)
			{
				node.highlighted = false;
				Tooltip.hideTooltipNow();
			}
		}
		pHighlighted?.setHighlighted();
	}

	private CubeNode getClosestNodeToCursor()
	{
		CubeNode result = null;
		float num = float.MaxValue;
		Vector2 a = Input.mousePosition;
		if (!InputHelpers.mouseSupported && InputHelpers.touchCount == 0)
		{
			return _active_node;
		}
		foreach (CubeNode node in _nodes)
		{
			Vector2 b = node.transform.position;
			float num2 = Vector2.Distance(a, b);
			if (!(num2 > 40f))
			{
				if (node == _active_node)
				{
					return node;
				}
				if (num2 < num)
				{
					num = num2;
					result = node;
				}
			}
		}
		return result;
	}

	private void smoothOffsets()
	{
		_offset_x = Mathf.Lerp(_offset_x, _offset_target_x, 0.1f);
		_offset_y = Mathf.Lerp(_offset_y, _offset_target_y, 0.1f);
	}

	internal bool isDragging()
	{
		return _is_dragging;
	}

	private void calculateNodeDepth(CubeNode pElement, float pRadius)
	{
		float z = pElement.transform.localPosition.z;
		float render_depth = Mathf.InverseLerp(0f - pRadius, pRadius, z);
		pElement.render_depth = render_depth;
	}

	private void sortNodesByDepth()
	{
		foreach (CubeNode node in _nodes)
		{
			node.transform.SetAsLastSibling();
		}
		_nodes.Sort((CubeNode a, CubeNode b) => a.render_depth.CompareTo(b.render_depth));
	}

	private void clearContent()
	{
		foreach (CubeNode node in _nodes)
		{
			node.clear();
		}
		foreach (CubeNodeConnection item in _pool_connections.getListTotal())
		{
			item.clear();
		}
		_rotation_q = Quaternion.identity;
		_rotation_q_2 = Quaternion.identity;
		_pool_connections.clear();
		_pool_nodes.clear();
		_nodes.Clear();
		_nodes_by_index.Clear();
	}

	public void OnDrag(PointerEventData eventData)
	{
		_is_dragging = true;
		Vector2 delta = eventData.delta;
		if (delta.magnitude > _last_mouse_delta.magnitude)
		{
			highlightAllConnectonsFromDrag(0.35f);
		}
		_last_mouse_delta = delta;
		_offset_x = (0f - delta.y) * 0.46f;
		_offset_y = delta.x * 0.46f;
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
		highlightAllConnectonsFromDrag(1f);
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
		Tooltip.hideTooltipNow();
	}

	private void updateNodeColorAndScale(CubeNode pNode)
	{
		Color color = ((!pNode.current_asset.isUnlockedByPlayer()) ? Toolbox.color_black : ((!pNode.highlighted) ? Color.Lerp(_color_node_back, _color_node_front, pNode.render_depth) : Color.Lerp(_color_node_back, _node_highlighted, pNode.render_depth)));
		pNode.setColor(color);
		float num = Mathf.Lerp(0.4f, 1.2f, pNode.render_depth);
		if (Mathf.Approximately(num, 0.4f))
		{
			pNode.setupAsset(getRandom());
		}
		num *= pNode.scale_mod_spawn * pNode.bonus_scale;
		num *= _mod_node_size;
		pNode.transform.localScale = new Vector3(num, num, num);
		pNode.updateTooltip();
	}

	private CubeNode getHighlightedNode()
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
		return getClosestNodeToCursor();
	}
}
