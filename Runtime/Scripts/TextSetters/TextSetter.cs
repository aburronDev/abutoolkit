using UnityEngine;
using TMPro;

namespace aburron.abutoolkit
{
	public abstract class TextSetter<T, U> : MonoBehaviour where U : Variable<T>
	{
		[SerializeField, Required] protected TextMeshProUGUI textReference;
		[SerializeField, Required] protected U textValue;

		private void OnEnable()
		{
			textValue.onValueChange += UpdateTextValue;
		}

		private void Start()
		{
			UpdateTextValue();
		}

		private void OnDestroy()
		{
			textValue.onValueChange -= UpdateTextValue;
		}

		protected virtual void UpdateTextValue()
		{
			textReference.text = textValue.GetValue().ToString();
		}
	}
}