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

            GameEvent e = target as GameEvent;
            if (GUILayout.Button("Fire Event"))
                e.FireEvent();
        }
    }
}