using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class wakeButton : MonoBehaviour
{
	public Button yourButton;

	void Start ()
	{
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick ()
	{
		if (RandomPrompt.wakeEvent) {
			RandomPrompt.wakeEvent = false; 
			RandomPrompt.eventPrompt = false;
			Image img = GameObject.Find ("WakePanel").GetComponent<Image> ();
			Color32 c = new Color32 (163, 161, 161, 100);
			img.color = c;
			comboScript.combo += .1f; 
		} else {
			int penalty = Random.Range (2, 4);
			comboScript.combo = 1; 
			SpawnAdvanced.spawnInterval = 2.0f;
			SpawnAdvanced.spawnInterval = SpawnAdvanced.spawnInterval / comboScript.combo; 
			GameObject[] gos = GameObject.FindGameObjectsWithTag ("snake");
			if (penalty >= gos.Length) {
				PlayerPrefs.SetInt ("Score", 0);
				SceneManager.LoadScene ("GameEnd");
			}
			for (int i = 0; i < penalty - 1; i++) { 
				if (GameObject.FindGameObjectWithTag ("snake") != null) { 
					Destroy (gos [i]);
				} else {
					PlayerPrefs.SetInt ("Score", 0);
					SceneManager.LoadScene ("GameEnd");
				}
			}
		}
	}
}