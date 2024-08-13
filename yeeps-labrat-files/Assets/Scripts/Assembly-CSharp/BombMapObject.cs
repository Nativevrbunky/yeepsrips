using UnityEngine;

public class BombMapObject : MultiRenderMapObject
{
	private const string _005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B = "fuse";

	private const string _005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B = "stopFuse";

	private const string _005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D = "explode";

	public const string signalChannelTrigger = "trigger";

	public const string signalChannelUntrigger = "untrigger";

	[Header("Bomb")]
	public _005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D explosionType;

	public float explosionRadius;

	public float fuseDuration;

	public string tickSoundKey;

	private bool _005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D;

	private bool _005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B;

	private bool _005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D;

	private float _005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B;

	private const int _005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D = 1;

	private Material _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B;

	private const float _005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D = 0.1f;

	public const float flashIntensity = 4f;

	private const int _005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D = 3;

	private float _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B;

	private const float _005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B = 1.5f;

	private const float _005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B = 4f;

	private bool _005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B;

	private void _005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D()
	{
	}

	private void _005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D()
	{
	}

	public override void Initialize(string _005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D, Vector3Int _005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B, _005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D, _005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B, string _005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B, string _005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B, bool _005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	public override void OnSignal(string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B)
	{
	}

	private void _005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B()
	{
	}

	public override void OnMasterPlayerCollided(Vector3 _005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D, Vector3 _005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D, Vector3 _005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B)
	{
	}

	private void _005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public override bool OnHit()
	{
		return false;
	}

	private void _005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D()
	{
	}

	private void Update()
	{
	}

	protected override _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D()
	{
		return default(_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D);
	}

	protected override Material[] _005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D(Material[] _005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D)
	{
		return null;
	}

	public override bool OnHitAndCollect()
	{
		return false;
	}

	public override bool DoCollisionMessaging()
	{
		return false;
	}

	private void _005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D()
	{
	}

	public override bool OnHit(Vector3 _005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D)
	{
		return false;
	}

	private void _005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D()
	{
	}

	private void _005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D()
	{
	}

	private void _005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B()
	{
	}

	public override bool IsTriggeredInsteadOfDestroyedOnHit()
	{
		return false;
	}

	public override void OnReceiveSimpleCustomMessage(bool _005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D, string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B)
	{
	}

	private void _005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D()
	{
	}
}
