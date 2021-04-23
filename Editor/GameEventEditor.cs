using UnityEngine;
using UnityEditor;

namespace aburron.abutoolkit
{
	[CustomEditor(typeof(GameEvent))]
	public class GameEventEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			GUI.enabled = Application.isPlaying;

			var gameEvent = (GameEvent)target;

			if (GUILayout.Button("Fire Event"))
				gameEvent.Fire();
		}
	}
}