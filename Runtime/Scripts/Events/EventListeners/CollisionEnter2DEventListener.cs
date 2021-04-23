using UnityEngine;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Events/Collision Enter2D Event Listener")]
	public class CollisionEnter2DEventListener : GameEventListener
	{
		private void OnCollisionEnter2D(Collision2D collision) => FireEvent();
	}
}