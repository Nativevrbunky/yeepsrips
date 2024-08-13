using UnityEngine;

public class FlowingWaterMapObject : MapObject
{
	[Header("Flowing Water")]
	public Vector3 localFlowDirection;

	private const float _005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D = 5.5f;

	private const float _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B = 6f;

	private const float _005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D = 11f;

	private const float _005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D = 0.25f;

	private const float _005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B = 1f;

	private const float _005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B = 0.1f;

	private const float _005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D = 0.1f;

	private float _005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D;

	private const float _005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B = 30f;

	private float _005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B;

	private MasterPlayer _005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D;

	private Vector3 _005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D;

	public string ambientSoundKey;

	private int _005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B;

	private void _005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B()
	{
	}

	private void _005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B()
	{
	}

	private void FixedUpdate()
	{
	}

	private void _005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B()
	{
	}

	public override bool DoCollisionMessaging()
	{
		return false;
	}

	private void _005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D()
	{
	}

	public override void OnMasterPlayerCollisionExit()
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B()
	{
	}

	private void _005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B()
	{
	}

	public override void Initialize(string _005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D, Vector3Int _005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B, _005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D, _005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B, string _005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B, string _005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B, bool _005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	public override void OnMasterPlayerCollided(Vector3 _005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D, Vector3 _005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D, Vector3 _005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B)
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B()
	{
	}

	protected override void _005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D()
	{
	}

	private void _005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	private void _005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B()
	{
	}

	private void _005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B()
	{
	}

	private void _005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D()
	{
	}

	private void _005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D()
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B()
	{
	}

	private void _005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	private void _005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B()
	{
	}
}
