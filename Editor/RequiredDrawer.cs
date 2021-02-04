using UnityEngine;
using UnityEditor;

namespace aburron.abutoolkit
{
	[CustomPropertyDrawer(typeof(RequiredAttribute))]
	public class RequiredDrawer : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			var height = base.GetPropertyHeight(property, label);

			return !property.objectReferenceValue ? height *= 3 : height;
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			position.height = EditorGUIUtility.singleLineHeight;

			EditorGUI.BeginProperty(position, label, property);

				if (!property.objectReferenceValue)
				{
					GUIStyle errorStyle = GUI.skin.GetStyle("HelpBox");

					errorStyle.fontSize = 13;
					errorStyle.richText = true;

					EditorGUI.HelpBox(new Rect(position.x, position.y, position.width, position.height * 2),
						$"<b>{property.displayName}</b> needs a reference to work", MessageType.Error);
				
					position.y += position.height * 2;
				}

				position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

				EditorGUI.PropertyField(position, property, GUIContent.none);

			EditorGUI.EndProperty();
		}
	}
}