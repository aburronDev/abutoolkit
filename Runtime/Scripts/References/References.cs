using System;

namespace aburron.abutoolkit
{
	[Serializable]
	public class IntReference : Reference<int, IntVariable>
	{
		public IntReference(int intValue) : base(intValue) { }
	}

	[Serializable]
	public class FloatReference : Reference<float, FloatVariable>
	{
		public FloatReference(float floatValue) : base(floatValue) { }
	}

	[Serializable]
	public class StringReference : Reference<string, StringVariable>
	{
		public StringReference(string stringValue) : base(stringValue) { }
	}
}