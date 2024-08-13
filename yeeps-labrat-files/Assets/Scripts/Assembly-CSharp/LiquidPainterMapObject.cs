using System.Runtime.CompilerServices;
using UnityEngine;

public class LiquidPainterMapObject : MapObject
{
	[CompilerGenerated]
	private sealed class _005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B
	{
		public _005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D roomData;

		public _005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D newLiquidTyle;

		public string newLiquidColorKey;

		public int newLiquidLevel;

		public LiquidPainterMapObject _003C_003E4__this;

		public RoomDatabase._005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B _003C_003E9__1;

		public RoomDatabase._005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B _003C_003E9__2;

		internal void _005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B()
		{
		}

		internal void _005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D(bool approved)
		{
		}

		internal void _005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D(string failCode)
		{
		}
	}

	private const string _005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B = "Liquid Painter: ";

	[Header("Liquid Painter")]
	public SimpleButtonController paintButton;

	public string paintLiquidSoundKey;

	private const string _005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B = "Failed to dye liquid: ";

	private void _005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B()
	{
	}

	public void _005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D()
	{
	}

	private void _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D()
	{
	}

	private void _005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B()
	{
	}

	public void _005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D()
	{
	}

	public void _005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D()
	{
	}

	public void _005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B()
	{
	}

	public void _005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D()
	{
	}

	private void _005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D()
	{
	}

	public void _005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D()
	{
	}

	public void _005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D()
	{
	}

	public void _005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B()
	{
	}

	private void _005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D()
	{
	}

	public void _005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B()
	{
	}

	public void _005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D()
	{
	}

	public void _005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B()
	{
	}

	public void _005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D()
	{
	}

	public void _005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D()
	{
	}

	private void _005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B()
	{
	}

	public void _005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D()
	{
	}

	public void _005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D()
	{
	}

	private void _005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D()
	{
	}

	public void _005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D()
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B()
	{
	}

	public void _005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D()
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B()
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B()
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	public void _005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B()
	{
	}

	public void _005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B()
	{
	}

	public void _005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B()
	{
	}

	private void _005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	public void _005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B()
	{
	}

	private void _005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D()
	{
	}

	private void _005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B()
	{
	}

	public void _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B()
	{
	}

	public void _005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B()
	{
	}

	public void _005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D()
	{
	}

	private void _005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D()
	{
	}

	private void _005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B()
	{
	}

	public void _005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D()
	{
	}

	public void OnPaintLiquidButtonPressed()
	{
	}

	public void _005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B()
	{
	}

	public void _005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B()
	{
	}

	private void _005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D()
	{
	}

	private void _005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}

	public void _005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D()
	{
	}

	private void _005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D(string _005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B)
	{
	}
}
