namespace aburron.abutoolkit.Variables
{
	[UnityEngine.CreateAssetMenu(fileName = "NewInt", menuName = "aburron/abutoolkit/Variables/Int")]
	public class IntVariable : NumericVariable<int> 
	{
		public override void IncreaseValue() => CurrentValue++;
		public override void DecreaseValue() => CurrentValue--;
	}
}