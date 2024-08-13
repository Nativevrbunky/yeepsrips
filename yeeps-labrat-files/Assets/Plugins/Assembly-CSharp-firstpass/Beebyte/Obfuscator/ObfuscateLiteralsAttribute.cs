using System;

namespace Beebyte.Obfuscator
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
	}
}
