using UnityEngine;

namespace aburron.abutoolkit
{
	[CreateAssetMenu(fileName = "NewFloat", menuName = "aburron/abutoolkit/Variables/Float")]
	public class FloatVariable : Variable<float> 
	{
		public void ChangeValue(float value) 
		{
			currentValue += value;
			onValueChange?.Invoke();
		} 

		public void IncreaseValue() => currentValue++;
		public void DecreaseValue() => currentValue--;
	}
}