using UnityEngine;
using UnityEngine.Events;

namespace aburron.abutoolkit.Events
{
	[AddComponentMenu("abutoolkit/Events/Game Event Response")]
	public class GameEventResponse : MonoBehaviour
	{
		[SerializeField] private GameEvent gameEvent;
		[SerializeField] private UnityEvent response;

		private void OnEnable() => gameEvent.Register(this);

		private void OnDisable() => gameEvent.Unregister(this);
		
		public void OnEventFired() => response?.Invoke();
	}
}