#if ENABLE_INPUT_SYSTEM
using UnityEngine;
using UnityEngine.InputSystem;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Events/Performed Action Event Listener")]
	public class PerformedActionEvent : GameEventListener
	{
		[SerializeField] private InputAction fireAction;

		private void Awake() => fireAction.performed += ctx => FireEvent();

		private void OnEnable() => fireAction.Enable();

		private void OnDisable() => fireAction.Disable();
	}
}
#endif
