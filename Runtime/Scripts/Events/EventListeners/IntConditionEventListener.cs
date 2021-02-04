using UnityEngine;
using aburron.abutoolkit.References;

namespace aburron.abutoolkit.Events
{
	[AddComponentMenu("abutoolkit/Events/Int Condition Event Listener")]
	public class IntConditionEventListener : GameEventListener
	{
		[SerializeField] private IntReference inConditionValue;
		[SerializeField] private IntReference outConditionValue;

		public void FireEventOnEqual()
		{
			if (inConditionValue == outConditionValue)
				FireEvent();
		}

		public void FireEventOnLessOrEqual()
		{
			if (inConditionValue <= outConditionValue)
				FireEvent();
		}

		public void FireEventOnGreaterOrEqual()
		{
			if (inConditionValue >= outConditionValue)
				FireEvent();
		}
	}
}