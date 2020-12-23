using UnityEngine;
using System.Collections.Generic;

namespace aburron.abutoolkit
{
	[CreateAssetMenu(fileName = "NewGameEvent", menuName = "aburron/abutoolkit/Events/GameEvent")]
	public class GameEvent : ScriptableObject
	{
        private readonly List<GameEventListener> eventListeners =
            new List<GameEventListener>();

        public void FireEvent()
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventFired();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}