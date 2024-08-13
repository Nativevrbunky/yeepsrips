using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class AssignCosmeticUtility : DatabaseUtility
{
	public string cosmeticKey;

	[TextArea]
	public string oculusNames;

	public TextAsset reviewInputFile;

	public string processedOculusNameFilePath;

	private const int _005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D = 3;

	private Task<List<string>> _005B_005B_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005D_005B_005D_005B_005B_005D_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005D_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005B_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005B_005D_005B_005B_005B_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005D_005D_005D_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005D_005D_005B_005B_005D_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005B_005B_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005D_005D_005B_005B_005D_005D_005B_005D_005D_005B_005B_005B_005B_005B_005B_005B_005B_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005D_005D_005D_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005B_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005D_005D_005B_005B_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005D_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005D_005D_005B_005D_005D_005D_005D_005B_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005B_005D_005D_005B_005B_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005D_005B_005D_005D_005B_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	[AsyncStateMachine(/*Could not decode attribute arguments.*/)]
	public override Task<bool> HandleUtility(string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005D_005B_005B_005D_005B_005B_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005B_005B_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005B_005B_005B_005B_005B_005B_005D_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005B_005D_005B_005B_005D_005D_005B_005B_005D_005B_005B_005D_005D_005B_005D_005B_005D_005D_005B_005D_005B_005D_005B_005B_005B_005D_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	[AsyncStateMachine(/*Could not decode attribute arguments.*/)]
	private Task<List<string>> _005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005B_005B_005B_005D_005D_005D_005D_005D_005B_005B_005B_005B_005D_005B_005D_005B_005D_005D_005D_005D_005D_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005D_005D_005B_005B_005D_005D_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005D_005B_005B_005D_005D_005B_005D_005D_005D_005B_005D_005D_005D_005B_005B_005D_005B(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}

	private Task<List<string>> _005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005B_005D_005D_005D_005B_005B_005D_005B_005B_005D_005D_005D_005D_005B_005B_005B_005B_005D_005D_005D_005D_005B_005D_005B_005B_005B_005D_005D_005B_005B_005B_005B_005B_005D_005D_005B_005D(List<string> _005D_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005B_005D_005B_005B_005B_005D_005B_005D_005D_005B_005B_005B_005B_005D_005B_005B_005D_005D_005D_005B_005D_005B_005D_005D_005D_005B_005D_005D_005B_005D_005B_005D_005B_005D_005D_005D, string _005B_005B_005B_005D_005B_005D_005B_005D_005B_005D_005B_005B_005D_005D_005B_005D_005B_005B_005B_005B_005D_005D_005D_005B_005B_005D_005D_005B_005D_005D_005D_005D_005D_005D_005B_005B_005D_005B_005D_005D_005B_005B_005D_005B_005D_005D_005D)
	{
		return null;
	}
}
