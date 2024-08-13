using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ClusterThoughtBubble : ThoughtBubble
{
	private const float _005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B = 45f;

	[Header("Preview")]
	public Transform previewObjectsContainer;

	public Transform patternObjectContainer;

	public Transform expandedObject;

	[Header("UI")]
	public GameObject canvas;

	public Text clusterText;

	private _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B;

	private Item._005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D _005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B;

	private const int _005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D = 12;

	private const float _005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D = 0.75f;

	private const float _005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D = 0.25f;

	public bool _005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B()
	{
		return null;
	}

	public void _005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B(_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B)
	{
	}

	public void _005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B()
	{
		return null;
	}

	[SpecialName]
	public bool _005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B()
	{
		return false;
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B GetPatternCollection()
	{
		return null;
	}

	public void _005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B(_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B)
	{
	}

	public void _005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public void _005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	public void _005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	public override void Initialize(Vector3 _005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B, Quaternion _005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B, bool _005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D, bool _005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B, _005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B _005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D = null, _005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B _005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B = null, _005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B _005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B = null)
	{
	}

	[SpecialName]
	public bool _005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B()
	{
		return false;
	}

	[SpecialName]
	private void _005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	public void SetPatternCollection(_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B)
	{
	}

	private void _005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B()
	{
	}

	[SpecialName]
	private void _005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D()
	{
	}

	[SpecialName]
	private void _005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	public void _005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	[SpecialName]
	private void _005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D()
	{
	}

	public void _005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	[SpecialName]
	private void _005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D()
	{
		return null;
	}

	public void SetExpanded(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B()
	{
	}

	[SpecialName]
	private void _005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	protected override void _005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B()
	{
		return null;
	}

	protected override void _005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B()
	{
	}

	public void _005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	public void _005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D(bool _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D()
	{
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D()
	{
		return null;
	}

	public _005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B _005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B()
	{
		return null;
	}

	private void _005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}
}
