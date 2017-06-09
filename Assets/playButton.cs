using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
	public void NextLevelButton (int index)
	{
		SceneManager.LoadScene ("Level1");
	}

	public void NextLevelButton (string levelName)
	{
		SceneManager.LoadScene ("Level1");
	}
}