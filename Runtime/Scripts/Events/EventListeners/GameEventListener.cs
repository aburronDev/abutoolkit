﻿using UnityEngine;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Events/Game Event Listener")]
	public class GameEventListener : MonoBehaviour
	{
		[SerializeField, Required] private GameEvent gameEvent;

		public virtual void FireEvent() => gameEvent?.Fire();
	}
}