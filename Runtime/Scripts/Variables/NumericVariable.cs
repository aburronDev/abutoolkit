namespace aburron.abutoolkit
{
	public abstract class NumericVariable<T> : Variable<T>
	{
		public virtual void ChangeValue(T value)
		{
			CurrentValue = value;
			OnValueChange?.Invoke();
		}

		public abstract void IncreaseValue();
		public abstract void DecreaseValue();
	}
}