using UnityEngine;

public class InnerTubeItem : ButtItem
{
	[Header("Inner Tube")]
	public Transform inLiquidTestPoint;

	public float hoverStrength;

	public float verticalDrag;

	public float lateralDrag;

	public float fastRiseAcceleration;

	public float fastRiseMaxSpeed;

	private const float _005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B = 2f;

	private bool _005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B;

	[Header("Bounciness")]
	public float bounceStrength;

	public float bounceSpeedThreshold;

	public LayerMask bounceLayerMask;

	public string bounceSoundKey;

	public string movementSoundKey;

	public string impactSoundKey;

	private const float _005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B = 0.25f;

	private const float _005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D = 5f;

	private Vector3 _005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B;

	private float _005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D;

	private const float _005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D = 0.25f;

	private float _005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B;

	private const float _005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B = 0.1f;

	private const float _005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D = 9f;

	private const float _005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B = 20f;

	private const float _005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D = 0.5f;

	private Vector3 _005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D;

	private float _005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D;

	private bool _005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B;

	private float _005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D;

	private float _005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D;

	private void _005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B()
	{
	}

	private void _005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B()
	{
	}

	private void _005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B()
	{
	}

	private void _005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D()
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B()
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B()
	{
	}

	private void _005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B()
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D()
	{
	}

	private void _005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B()
	{
	}

	private void _005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B()
	{
	}

	private void _005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B()
	{
	}

	private void _005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B()
	{
	}

	private void _005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D()
	{
	}

	private void _005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D()
	{
	}

	private void _005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B()
	{
	}

	protected override void _005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D(MasterPlayer _005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B()
	{
	}

	private void _005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D()
	{
	}

	private void _005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D()
	{
	}

	protected override void _005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D(MasterPlayer _005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	private void _005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B()
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B()
	{
	}

	private void _005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B()
	{
	}

	protected override void _005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B()
	{
	}

	private void _005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B()
	{
	}

	private void _005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B()
	{
	}

	private void _005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D(Collision _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D)
	{
	}
}
