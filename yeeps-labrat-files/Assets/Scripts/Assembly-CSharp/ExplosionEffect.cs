using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
	private const int _005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D = 32;

	private static int _005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B;

	public LayerMask mapObjectLayerMask;

	public bool destroysStuffedMapObjects;

	public bool doPlayerKnockback;

	public Player._005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B statusEffect;

	public float statusEffectDuration;

	public string soundKey;

	private const float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D = 0.6f;

	private float _005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B;

	private float _005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B;

	private float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B;

	private const float _005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D = 4f;

	private const float _005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D = 4f;

	private const float _005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B = 15f;

	private const float _005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B = 0.75f;

	private const float _005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D = 0.5f;

	private Material _005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D;

	private Color _005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B;

	private float _005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D;

	private const float _005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B = 0.75f;

	private const float _005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D = 3f;

	private const float _005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D = 0.33f;

	private const float _005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B = 1.5f;

	public static bool _005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D()
	{
		return false;
	}

	private void _005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D()
	{
	}

	public void _005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public static bool _005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D()
	{
		return false;
	}

	private void Update()
	{
	}

	public static bool _005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D()
	{
		return false;
	}

	public void _005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B()
	{
	}

	public static bool _005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D()
	{
		return false;
	}

	public void _005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D()
	{
	}

	public void _005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public static bool _005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B()
	{
		return false;
	}

	public static bool _005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D()
	{
		return false;
	}

	public void Initialize(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B()
	{
	}

	public static bool _005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D()
	{
		return false;
	}

	private void _005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B()
	{
	}

	public void _005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public static bool _005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D()
	{
		return false;
	}

	public void _005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D()
	{
	}

	public void _005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public void _005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public static bool CanCreateEffect()
	{
		return false;
	}

	private void _005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D()
	{
	}

	public void _005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public void _005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public void _005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	public void _005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public static bool _005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B()
	{
		return false;
	}

	public static bool _005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B()
	{
		return false;
	}

	private void _005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public void _005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public void _005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	public void _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	private void _005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B()
	{
	}

	public void _005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D()
	{
	}

	private void _005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B()
	{
	}

	private void _005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D()
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B()
	{
	}

	public static bool _005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D()
	{
		return false;
	}

	public void _005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D()
	{
	}

	public static bool _005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D()
	{
		return false;
	}

	private void _005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B()
	{
	}

	private void _005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B()
	{
	}

	public void _005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B, float _005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B = 1f, bool _005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B = false)
	{
	}
}
