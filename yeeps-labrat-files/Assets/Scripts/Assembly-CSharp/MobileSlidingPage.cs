using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MobileSlidingPage : MonoBehaviour
{
	public delegate void _005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D);

	public GameObject escapeZoneContainer;

	public RectTransform slidingRect;

	public AnimationCurve slideInCurve;

	public float slideInDuration;

	public AnimationCurve slideOutCurve;

	public float slideOutDuration;

	private int _005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D;

	private float _005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B;

	private Coroutine _005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B;

	private bool _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D;

	public _005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D onSetActiveCallbacks;

	public bool _005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D
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

	public void _005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D()
	{
	}

	private void _005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	private void _005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B(bool _005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B)
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B()
	{
	}

	[SpecialName]
	public bool _005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B()
	{
		return false;
	}

	protected virtual void _005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B()
	{
	}

	private void _005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D()
	{
	}

	protected virtual void _005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B()
	{
	}

	[SpecialName]
	public bool _005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D()
	{
		return false;
	}

	protected virtual void _005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected virtual void _005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	private IEnumerator _005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B()
	{
		return null;
	}

	private void _005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	protected virtual void _005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B()
	{
	}

	protected virtual void _005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected virtual void _005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D()
	{
	}

	public void _005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	[SpecialName]
	private void _005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	protected virtual void _005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D(bool _005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D(bool _005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B)
	{
	}

	protected virtual void _005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D()
	{
	}

	private IEnumerator _005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	private IEnumerator _005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	private void _005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D(bool _005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B)
	{
	}

	private IEnumerator _005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D()
	{
		return null;
	}

	private void _005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	public void _005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D()
	{
	}

	protected virtual void _005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D()
	{
	}

	public void _005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	public void SetActive(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	protected virtual void _005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D()
	{
	}

	[SpecialName]
	public bool _005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D()
	{
		return false;
	}

	private void _005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B(bool _005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B)
	{
	}

	protected virtual void _005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected virtual void _005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B()
	{
	}

	[SpecialName]
	private void _005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	public void _005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B()
	{
	}

	protected virtual void _005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	[SpecialName]
	public bool _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D()
	{
		return false;
	}

	private IEnumerator _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private IEnumerator _005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	protected virtual void _005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B()
	{
	}

	private IEnumerator _005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	private void _005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B()
	{
	}

	private void _005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D()
	{
	}

	protected virtual void _005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D()
	{
	}

	private void _005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D()
	{
	}

	public void _005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D()
	{
	}

	protected virtual void _005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	public void OnCloseButtonPressed()
	{
	}

	private IEnumerator _005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B()
	{
		return null;
	}

	protected virtual void _005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	public void _005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B()
	{
	}

	private IEnumerator _005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	protected virtual void _005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D()
	{
	}

	protected virtual void _005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	[SpecialName]
	private void _005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	public void _005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public void ToggleActive()
	{
	}

	[SpecialName]
	public bool _005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D()
	{
		return false;
	}

	[SpecialName]
	private void _005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private IEnumerator _005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D()
	{
		return null;
	}

	public void _005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	private void _005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D()
	{
	}

	protected virtual void _005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B()
	{
	}

	protected virtual void _005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private IEnumerator _005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B()
	{
		return null;
	}

	private void _005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B()
	{
	}

	protected virtual void _005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D()
	{
	}

	private void _005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D()
	{
	}

	private void Start()
	{
	}

	protected virtual void _005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D()
	{
	}

	public void _005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D()
	{
	}

	private void _005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	protected virtual void _005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D()
	{
	}

	[SpecialName]
	public bool _005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B()
	{
		return false;
	}

	public void _005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D()
	{
	}

	private IEnumerator _005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B(float _005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B, AnimationCurve _005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D)
	{
		return null;
	}

	public void _005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D()
	{
	}

	private void _005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D(float _005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D)
	{
	}

	public void _005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	protected virtual void _005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}
}
