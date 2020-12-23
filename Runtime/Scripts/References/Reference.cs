using UnityEngine;
using System;

namespace aburron.abutoolkit
{
	[Serializable]
	public abstract class Reference { }

	[Serializable]
	public class Reference<T, U> : Reference where U : Variable<T>
	{
		[SerializeField] private bool useConstantValue = true;
		[SerializeField] private T constantValue;
		[SerializeField] private U variableValue;

		public Reference() { }

		public Reference(T value)
		{
			useConstantValue = true;
			constantValue = value;
		}

		public T runtimeValue { get => useConstantValue ? constantValue : variableValue.GetValue(); }

		public static implicit operator T (Reference<T, U> reference) => reference.runtimeValue;
		public static implicit operator Reference<T, U> (T value) => new Reference<T, U>(value);
	}
}