using System;
using UnityEngine;

namespace aburron.abutoolkit
{
	[Serializable]
	public class IntReference : Reference<int, IntVariable>
	{
		public IntReference(int intValue) : base(intValue) { }
		public IntReference() { }
	}

	[Serializable]
	public class FloatReference : Reference<float, FloatVariable>
	{
		public FloatReference(float floatValue) : base(floatValue) { }
		public FloatReference() { }
	}

	[Serializable]
	public class StringReference : Reference<string, StringVariable>
	{
		public StringReference(string stringValue) : base(stringValue) { }
		public StringReference() { }
	}
}