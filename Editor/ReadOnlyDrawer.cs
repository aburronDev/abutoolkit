using UnityEngine;
using UnityEditor;

namespace aburron.abutoolkit
{
	[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
	public class ReadOnlyDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			using (var scope = new EditorGUI.DisabledGroupScope(true))
				EditorGUI.PropertyField(position, property, label, true);
		}
	}
}