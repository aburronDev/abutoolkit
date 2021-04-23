using UnityEngine;
using UnityEditor;

namespace aburron.abutoolkit
{
	[CustomPropertyDrawer(typeof(Reference))]
	public class ReferenceDrawer : PropertyDrawer
	{
		private readonly string[] popupOption = { "Constant Value", "Variable Value" };

		private GUIStyle popupStyle;

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (popupStyle == null)
			{
				popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
				popupStyle.imagePosition = ImagePosition.ImageOnly;
			}

			label = EditorGUI.BeginProperty(position, label, property);
			position = EditorGUI.PrefixLabel(position, label);

			SerializedProperty useConstantValue = property.FindPropertyRelative(nameof(useConstantValue));
			SerializedProperty constantValue = property.FindPropertyRelative(nameof(constantValue));
			SerializedProperty variableValue = property.FindPropertyRelative(nameof(variableValue));

			EditorGUI.BeginChangeCheck();

			Rect buttonRect = new Rect(position);
			buttonRect.yMin += popupStyle.margin.top;
			buttonRect.width = popupStyle.fixedWidth + popupStyle.margin.right;
			position.xMin = buttonRect.xMax;

			int indent = EditorGUI.indentLevel;
			int result = EditorGUI.Popup(buttonRect, useConstantValue.boolValue ? 0 : 1, popupOption, popupStyle);
			EditorGUI.indentLevel = 0;
			useConstantValue.boolValue = result == 0;
			EditorGUI.PropertyField(position, useConstantValue.boolValue ? constantValue : variableValue, GUIContent.none);

			if (EditorGUI.EndChangeCheck())
				property.serializedObject.ApplyModifiedProperties();

			EditorGUI.indentLevel = indent;
			EditorGUI.EndProperty();
		}
	}

	[CustomPropertyDrawer(typeof(FloatReference))]
	public class FloatReferenceDrawer : ReferenceDrawer { }

	[CustomPropertyDrawer(typeof(IntReference))]
	public class IntReferenceDrawer : ReferenceDrawer { }

	[CustomPropertyDrawer(typeof(StringReference))]
	public class StringReferenceDrawer : ReferenceDrawer { }
}