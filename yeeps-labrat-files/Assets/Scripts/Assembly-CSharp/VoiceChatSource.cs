using UnityEngine;

public class VoiceChatSource : MonoBehaviour
{
	private bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B;

	private string _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D;

	private bool _005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D;

	public bool animateWithAudio;

	public float audioEnergyToScaleIncreaseRatio;

	private float _005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B;

	public float maxAudioEnergy;

	private const float _005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B = 8f;

	private string _005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D;

	private void _005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B()
	{
	}

	public void _005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D()
	{
	}

	private void _005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D()
	{
	}

	private void _005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D()
	{
	}

	private void _005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D(float _005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B)
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B()
	{
	}

	public void Initialize(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, string _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D, bool _005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	public Vector3 _005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B()
	{
		return default(Vector3);
	}

	private void _005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	public void _005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, string _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D, bool _005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	public void SetActive(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void _005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, string _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D, bool _005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	public void _005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	public void _005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B()
	{
	}

	public void _005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B()
	{
	}

	private void _005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B()
	{
	}

	private void _005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D()
	{
	}

	public void _005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, string _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D, bool _005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	public void _005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B(bool _005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B, string _005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D, bool _005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005D)
	{
	}

	private void _005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D()
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B(float _005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D()
	{
	}

	private void _005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B(float _005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B)
	{
	}

	public Vector3 _005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B()
	{
		return default(Vector3);
	}

	private void _005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B()
	{
	}

	private void _005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B()
	{
	}

	private void _005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B()
	{
	}

	private void _005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B()
	{
	}

	public void _005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B(bool _005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D)
	{
	}

	public Vector3 _005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B()
	{
		return default(Vector3);
	}

	private void _005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B()
	{
	}

	private void OnEnable()
	{
	}

	private void _005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B(float _005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B)
	{
	}

	private void _005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B()
	{
	}

	private void _005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D(float _005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B)
	{
	}

	private void OnDisable()
	{
	}

	private void _005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public Vector3 _005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D()
	{
		return default(Vector3);
	}

	private void _005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D(float _005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B)
	{
	}

	public Vector3 _005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D()
	{
		return default(Vector3);
	}
}
