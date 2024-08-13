using System;
using UnityEngine;

public class MapObjectSwapHelper : MonoBehaviour
{
	[Serializable]
	public struct SwapData
	{
		public string mapObjectKey;

		public bool acceptPartialMatch;

		public string colorKeyRestriction;

		public string newMapObjectKey;

		public string newMapObjectColorKey;
	}

	public KeyCode swapKey;

	public SwapData[] swapDatas;

	private float _005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D;

	private const float _005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D = 1f;
}
