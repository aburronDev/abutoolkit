using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace aburron.abutoolkit
{
	public class SceneTools
	{
		public static List<string> GetAllScenesInBuild()
		{
			var scenes = new List<string>();

			for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
			{
				var scenePath = SceneUtility.GetScenePathByBuildIndex(i);
				var sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);
				scenes.Add(sceneName);
			}

			return scenes;
		}
	}
}