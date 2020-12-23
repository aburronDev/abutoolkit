using UnityEngine;

namespace aburron.abutoolkit
{
	[CreateAssetMenu(fileName = "NewInt", menuName = "aburron/abutoolkit/Variables/Int")]
	public class IntVariable : Variable<int> 
	{
		public void ChangeValue(int value)
		{
			currentValue += value;
			onValueChange?.Invoke();
		}

		public void IncreaseValue() => ChangeValue(1);
		public void DecreaseValue() => ChangeValue(-1);
	}
}