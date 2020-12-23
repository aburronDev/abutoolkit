using UnityEngine;
using UnityEngine.Events;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Events/GameEventListener")]
	public class GameEventListener : MonoBehaviour
	{
		[SerializeField] private GameEvent gameEvent;
		[SerializeField] private UnityEvent response;

		private void OnEnable() => gameEvent.RegisterListener(this);

		private void OnDisable() => gameEvent.UnregisterListener(this);
		
		public void OnEventFired() => response?.Invoke();
	}
}