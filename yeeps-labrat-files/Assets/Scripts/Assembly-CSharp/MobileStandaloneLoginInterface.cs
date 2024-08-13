using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MobileStandaloneLoginInterface : Singleton<MobileStandaloneLoginInterface>
{
	private delegate void _005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D();

	[CompilerGenerated]
	private sealed class _005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005B_005B_005D
	{
		public MobileStandaloneLoginInterface _003C_003E4__this;

		public bool instant;

		public AccountManager._005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B onFailed;

		internal void _005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B(string accountID, _005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D accountData, DateTime serverTime)
		{
		}

		internal void _005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B(string errorMessage, string errorCode)
		{
		}
	}

	public MobileLoginMenu loginMenu;

	public Text accessDeniedTitleText;

	public Text accessDeniedBodyText;

	public Text accessDeniedRecoverySuggestionText;

	public Image faderImage;

	public float revealDuration;

	public GameObject buttonContainer;

	public TapButton2D loginButton;

	public TapButton2D logoutButton;

	public TapButton2D restartButton;

	private const int _005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B = 40;

	private const int _005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D = 3;

	private static bool _005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D;

	private static string _005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D;

	private static string _005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B;

	private static string _005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B;

	private static bool _005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B;

	private Coroutine _005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B;

	private float _005D_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B;

	public static bool hasStoredAccountData;

	public static string _005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static _005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D _005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static DateTime _005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool _005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string _005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void _005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D(float _005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false, _005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D _005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D = null)
	{
	}

	[SpecialName]
	public static _005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D _005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B()
	{
		return null;
	}

	private void _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D()
	{
	}

	private void Start()
	{
	}

	public void OnLogoutButtonPressed()
	{
	}

	private void _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B(float _005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false, _005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D _005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D = null)
	{
	}

	private void _005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005B(AccountManager._005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B _005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D)
	{
	}

	[SpecialName]
	private static void _005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D(string _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private IEnumerator _005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B(float _005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D, _005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D _005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D = null)
	{
		return null;
	}

	[SpecialName]
	private static void _005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D(DateTime _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	[SpecialName]
	private static void _005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D(_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B(string _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D, string _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, string _005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D, bool _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D, bool _005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D = false)
	{
	}

	[SpecialName]
	private static void _005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B(DateTime _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	private void _005B_005B_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B()
	{
	}

	private void Awake()
	{
	}

	private void _005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D(float _005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B)
	{
	}

	public void OnOpenLoginMenuButtonPressed()
	{
	}

	private void _005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private IEnumerator _005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B(float _005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D, _005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D _005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D = null)
	{
		return null;
	}

	[SpecialName]
	private static void _005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B(DateTime _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	public void OnRestartButtonPressed()
	{
	}

	public static void _005B_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B(string _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D, string _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, string _005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D, bool _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D)
	{
	}

	public static void _005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D(string _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D, string _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, string _005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D, bool _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D)
	{
	}

	public void _005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D()
	{
	}

	private void _005B_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B()
	{
	}

	private void _005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005D(string _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D, string _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, string _005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D, bool _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D, bool _005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D = false)
	{
	}

	private void _005B_005D_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B()
	{
	}

	public static void OpenForLogin()
	{
	}

	private void _005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D(string _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D, string _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, string _005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D, bool _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D, bool _005B_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005D = false)
	{
	}

	private void _005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D()
	{
	}

	public static void StoreCompatibilityInfo(bool _005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B, string _005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B)
	{
	}

	public static void StoreMobileAccountData(string _005B_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005D, _005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D _005B_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D, DateTime _005D_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B)
	{
	}

	[SpecialName]
	private static void _005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D(string _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	[SpecialName]
	private static void _005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	[SpecialName]
	private static void _005B_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B(bool _005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D)
	{
	}

	public static void OpenWithAccessDenied(string _005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D, string _005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B, string _005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D, bool _005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D)
	{
	}

	private void _005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005D(float _005D_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005B, float _005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005D_005D_005B_005D, bool _005D_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D = false, _005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005B_005D _005B_005B_005B_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D = null)
	{
	}

	[SpecialName]
	public static string _005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005D_005D_005D_005B_005B()
	{
		return null;
	}
}
