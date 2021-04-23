using UnityEngine;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Events/Timer Event Listener")]
	public class TimerEventListener : GameEventListener
	{
		[SerializeField] private FloatReference timeDelay;

		private float timer;

		private void Update()
		{
			if (timer > 0)
				timer -= Time.deltaTime;

			if (timer <= 0)
				FireEvent();
		}

		public void StartTimer() => timer = timeDelay;
	}
}