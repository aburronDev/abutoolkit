namespace aburron.abutoolkit.Scenes
{
	[System.Serializable]
	public class SceneBuild
	{
		[UnityEngine.SerializeReference] private string name;

		public string Name { get => name; set => name = value; }

		public SceneBuild(string name) => Name = name;
	}
}