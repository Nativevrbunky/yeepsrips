using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ObservationDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D
	{
		public ObservationDisplay _003C_003E4__this;

		public string curFetchPlayerApperanceAccountID;

		internal void _005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D(PlayerAppearanceManager._005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D playerAppearance)
		{
		}

		internal void _005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D(string errType)
		{
		}
	}

	public Text displayNameText;

	public Avatar avatar;

	private Vector3 _005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B;

	private Quaternion _005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B;

	private const float _005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B = 10f;

	public float height;

	private const float _005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D = 0.5f;

	public float distanceToSizeRatio;

	public float minSize;

	private MasterPlayer _005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D;

	private const float _005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D = 0.1f;

	private string _005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D;

	private void Update()
	{
	}

	public void _005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B(Player _005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D)
	{
	}

	private void _005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D()
	{
	}

	private void _005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B()
	{
	}

	public void _005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B(Vector3 _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B, Vector3 _005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	private void _005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public void Display(Player _005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D)
	{
	}

	public void _005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B(string _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D)
	{
	}

	public void _005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B(string _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D)
	{
	}

	public void SetPosition(Vector3 _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B, Vector3 _005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	public void _005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B(Vector3 _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B, Vector3 _005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	public void _005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B(Player _005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D()
	{
	}

	public void _005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D(Vector3 _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B, Vector3 _005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	public void _005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B(string _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D)
	{
	}

	public void _005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D(Vector3 _005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B, Vector3 _005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false)
	{
	}

	private void _005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D()
	{
	}

	public void Display(string _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D)
	{
	}
}
