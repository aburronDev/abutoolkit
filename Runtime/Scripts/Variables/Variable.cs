using System;
using UnityEngine;

namespace aburron.abutoolkit
{
	public abstract class Variable<T> : ScriptableObject
	{
		public Action OnValueChange { get; set; }

		[SerializeField] private T currentValue;

		public T CurrentValue { get => currentValue; set => currentValue = value; }

		public void OnValidate() => OnValueChange?.Invoke();
	}
}