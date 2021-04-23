using UnityEngine;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Events/Start Event Listener")]
	public class StartEvent : GameEventListener
	{
		private void Start() => FireEvent();
	}
}