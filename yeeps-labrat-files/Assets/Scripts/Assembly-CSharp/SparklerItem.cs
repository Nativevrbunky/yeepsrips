using UnityEngine;

public class SparklerItem : DespawningItem
{
	[Header("Sparkler")]
	public ParticleSystem particles;

	public TrailRenderer trail;

	public string soundKey;

	private AudioSource _005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B;

	private bool _005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B;

	private const float _005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B = 0.1f;

	private const float _005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D = 0.1f;

	private float _005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D;

	private bool _005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B;

	[Header("Bounds")]
	public Vector3 boundingCenter;

	public float boundingRadius;

	private void _005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected override void _005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D()
	{
	}

	private void _005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected override bool _005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B()
	{
		return false;
	}

	private void _005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	public override void GetBounds(out Vector3 _005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D, out float _005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B)
	{
		_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D = default(Vector3);
		_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B = default(float);
	}

	protected override void _005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D()
	{
	}

	private void _005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected override void _005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D()
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	public override void Initialize(string _005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D, string _005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D, _005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D _005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D, _005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B _005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, _005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D _005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	protected override void _005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B()
	{
	}
}
