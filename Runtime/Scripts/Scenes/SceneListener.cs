using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace aburron.abutoolkit
{
	[AddComponentMenu("abutoolkit/Scenes/Scene Listener")]
	public class SceneListener : MonoBehaviour, ISerializationCallbackReceiver
	{
		public static List<string> scenesInBuild;
		[SerializeField] LoadSceneMode sceneMode;

		[SerializeField] protected SceneBuild scene;

		public void OnAfterDeserialize() { }

		public void OnBeforeSerialize() => scenesInBuild = SceneTools.GetAllScenesInBuild();

		public void LoadScene() => SceneManager.LoadScene(scene.Name, sceneMode);

		public void LoadSceneAsync() => SceneManager.LoadSceneAsync(scene.Name, sceneMode);

		public void UnloadScene() => SceneManager.UnloadSceneAsync(scene.Name);
	}
}