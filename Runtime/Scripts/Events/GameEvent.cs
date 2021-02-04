using System.Collections.Generic;
using UnityEngine;

namespace aburron.abutoolkit.Events
{
	[CreateAssetMenu(fileName = "NewGameEvent", menuName = "aburron/abutoolkit/Events/Game Event")]
	public class GameEvent : ScriptableObject
	{
		private readonly List<GameEventResponse> responses = new List<GameEventResponse>();

		public void Fire()
		{
			for (int i = responses.Count - 1; i >= 0; i--)
				responses[i].OnEventFired();
		}

		public void Register(GameEventResponse response)
		{
			if (!responses.Contains(response))
				responses.Add(response);
		}

		public void Unregister(GameEventResponse response)
		{
			if (responses.Contains(response))
				responses.Remove(response);
		}
	}
}