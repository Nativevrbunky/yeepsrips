using UnityEngine;

public class SlopeColliderBatchingMapObject : MapObject
{
	[Header("Slope Collider Batching")]
	public string colliderBatchKey;

	public bool supportsVerticalColliderBatching;

	public string verticalColliderBatchKey;

	public override string GetColliderBatchKey()
	{
		return null;
	}

	public override void OnColliderBatchIsBakedUpdated(bool _005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D)
	{
	}
}
