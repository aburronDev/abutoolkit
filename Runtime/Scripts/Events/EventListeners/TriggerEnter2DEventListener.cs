using UnityEngine;

namespace aburron.abutoolkit.Events
{
	[AddComponentMenu("abutoolkit/Events/Triger Enter2D Event Listener")]
	public class TriggerEnter2DEventListener : GameEventListener
	{
		private void OnTriggerEnter2D(Collider2D collision) => FireEvent();
	}
}