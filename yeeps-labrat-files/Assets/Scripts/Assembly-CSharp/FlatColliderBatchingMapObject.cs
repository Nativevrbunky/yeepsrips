using UnityEngine;

public class FlatColliderBatchingMapObject : MapObject
{
	[Header("Collider Batching")]
	public string colliderBatchKey;

	public override string GetColliderBatchKey()
	{
		return null;
	}
}
