using System.Collections.Generic;

public class SignalManager : Singleton<SignalManager>
{
	private const string _005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B = "Signals: ";

	private Dictionary<_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D, List<MapObject>> _005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D;

	public void _005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B(_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D, string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B = null)
	{
	}

	public void _005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D(_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D, string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B = null)
	{
	}

	public void RegisterSignalReceiver(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B(_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D, string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B = null)
	{
	}

	public void _005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void DeregisterSignalReceiver(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void _005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B(MapObject _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B, _005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D)
	{
	}

	public void TriggerSignalChannel(_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D, string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B = null)
	{
	}

	public void _005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B(_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D _005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D, string _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B = null)
	{
	}
}
