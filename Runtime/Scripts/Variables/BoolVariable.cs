using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace aburron.abutoolkit
{
	[CreateAssetMenu(fileName = "NewBool", menuName = "aburron/abutoolkit/Variables/Bool")]
	public class BoolVariable : ScriptableObject
	{
		public bool CurrentValue;
	}
}