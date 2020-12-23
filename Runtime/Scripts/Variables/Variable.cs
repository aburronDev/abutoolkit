using UnityEngine;
using System;

namespace aburron.abutoolkit
{
	public abstract class Variable<T> : ScriptableObject
	{
		public Action onValueChange;

		[SerializeField] protected T currentValue;

		public T CurrentValue { get => currentValue; set => currentValue = value; }

		public void OnValidate() => onValueChange?.Invoke();

		public T GetValue() => currentValue;

		public void SetValue(T value)
		{
			currentValue = value;
			onValueChange?.Invoke();
		}

		public void SetValue(Variable<T> variable) 
		{
			currentValue = variable.currentValue;
			onValueChange?.Invoke();
		}
	}
}