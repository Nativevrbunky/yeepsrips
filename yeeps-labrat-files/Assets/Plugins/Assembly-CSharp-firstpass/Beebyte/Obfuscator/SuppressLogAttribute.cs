using System;

namespace Beebyte.Obfuscator
{
	[AttributeUsage(AttributeTargets.Method)]
	public class SuppressLogAttribute : Attribute
	{
		private readonly MessageCode _messageCode;

		private SuppressLogAttribute()
		{
		}

		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
