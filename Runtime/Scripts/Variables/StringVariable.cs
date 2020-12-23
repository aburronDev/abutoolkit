using UnityEngine;

namespace aburron.abutoolkit
{
	[CreateAssetMenu(fileName = "NewString", menuName = "aburron/abutoolkit/Variables/String")]
	public class StringVariable : Variable<string> 
	{
		public void Join(string text) => currentValue += text;
	}
}