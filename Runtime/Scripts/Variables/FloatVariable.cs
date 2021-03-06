﻿namespace aburron.abutoolkit
{
	[UnityEngine.CreateAssetMenu(fileName = "NewFloat", menuName = "aburron/abutoolkit/Variables/Float")]
	public class FloatVariable : NumericVariable<float> 
	{
		public override void IncreaseValue() => CurrentValue++;
		public override void DecreaseValue() => CurrentValue--;
	}
}