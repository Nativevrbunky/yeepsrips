using System.Runtime.CompilerServices;
using UnityEngine;

public class MapShifter : MapObject
{
	[CompilerGenerated]
	private sealed class _005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B
	{
		public string targetRoomKey;

		public Vector3Int shift;

		public bool isDestructive;

		public string direction;

		public MapShifter _003C_003E4__this;

		internal void _005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D(bool approved)
		{
		}
	}

	public string shiftSoundKey;

	private const string _005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B = "Map Shifter: ";

	private const string _005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B = "Failed to shift: ";

	public void _005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B()
	{
	}

	public void _005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D()
	{
	}

	public void _005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B()
	{
	}

	public void _005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D()
	{
	}

	public void _005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D()
	{
	}

	private void _005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B()
	{
	}

	public void _005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B()
	{
	}

	public void _005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D()
	{
	}

	public void _005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D()
	{
	}

	private void _005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B()
	{
	}

	public void _005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D()
	{
	}

	public void _005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B()
	{
	}

	public void _005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D()
	{
	}

	public void _005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B()
	{
	}

	private void _005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B()
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void OnDestructiveShiftMapYNegativeButtonPressed()
	{
	}

	public void _005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B()
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D()
	{
	}

	public void _005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B()
	{
	}

	public void OnShiftMapXNegativeButtonPressed()
	{
	}

	public void _005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B()
	{
	}

	public void OnShiftMapYNegativeButtonPressed()
	{
	}

	public void OnShiftMapXPositiveButtonPressed()
	{
	}

	private void _005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B()
	{
	}

	public void _005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D()
	{
	}

	public void _005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	public void _005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B()
	{
	}

	public void _005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D()
	{
	}

	public void _005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D()
	{
	}

	public void _005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B()
	{
	}

	public void _005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B()
	{
	}

	public void _005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B()
	{
	}

	private void _005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	private void _005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	public void _005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D()
	{
	}

	public void _005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D()
	{
	}

	public void _005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D()
	{
	}

	public void _005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B()
	{
	}

	public void _005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B()
	{
	}

	public void _005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B()
	{
	}

	public void _005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D()
	{
	}

	public void _005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B()
	{
	}

	private void _005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B()
	{
	}

	public void _005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D()
	{
	}

	public void _005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B()
	{
	}

	public void _005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B()
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	private void _005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D()
	{
	}

	public void _005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D()
	{
	}

	public void _005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B()
	{
	}

	public void _005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B()
	{
	}

	public void _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D()
	{
	}

	public void _005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	public void _005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D()
	{
	}

	public void OnShiftMapZPositiveButtonPressed()
	{
	}

	public void _005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D()
	{
	}

	public void _005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D()
	{
	}

	public void _005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D()
	{
	}

	public void OnShiftMapYPositiveButtonPressed()
	{
	}

	public void _005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B()
	{
	}

	private void _005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B()
	{
	}

	public void _005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D()
	{
	}

	public void _005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D()
	{
	}

	public void OnShiftMapZNegativeButtonPressed()
	{
	}

	private void _005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D()
	{
	}

	public void _005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B()
	{
	}

	private void _005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D()
	{
	}

	public void _005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D()
	{
	}

	public void _005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B()
	{
	}

	public void _005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B()
	{
	}

	public void _005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D()
	{
	}

	private void _005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B()
	{
	}

	public void _005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B()
	{
	}

	public void _005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D()
	{
	}

	private void _005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B()
	{
	}

	public void _005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B()
	{
	}

	public void _005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B()
	{
	}

	public void _005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B()
	{
	}

	private void _005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D(_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D _005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B, bool _005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B = false)
	{
	}

	public void _005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B()
	{
	}

	private void _005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D()
	{
	}

	public void _005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B()
	{
	}

	public void _005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D()
	{
	}

	public void _005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D()
	{
	}

	public void _005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B()
	{
	}

	private void _005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B()
	{
	}

	public void _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D()
	{
	}
}
