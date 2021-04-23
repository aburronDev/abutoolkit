using UnityEngine;
using UnityEditor;

namespace aburron.abutoolkit
{
	[CustomPropertyDrawer(typeof(SceneBuild))]
	public class SceneBuildDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var elements = SceneTools.GetAllScenesInBuild();
			var sceneName = property.FindPropertyRelative("name");

			if (elements != null && elements.Count != 0)
			{
				var selectedIndex = Mathf.Max(elements.IndexOf(sceneName.stringValue), 0);
				selectedIndex = EditorGUI.Popup(position, property.name, selectedIndex, elements.ToArray());
				sceneName.stringValue = elements[selectedIndex];
			}
			else EditorGUI.LabelField(position, "No Scenes in build");
		}
	}
}