using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class eventTimer : MonoBehaviour
{
	public static float timeLeft;
	public Text eventText;

	void Start ()
	{
	}

	void Update ()
	{
		timeLeft -= Time.deltaTime;
		eventText.text = Mathf.Round (timeLeft).ToString ();

		if (timeLeft < 0) {
			RandomPrompt.eventPrompt = false; 
			comboScript.combo = 1.0f;
			SpawnAdvanced.spawnInterval = 2.0f;
			Color32 c = new Color32 (163, 161, 161, 100);
			Image img = GameObject.Find ("KillPanel").GetComponent<Image> ();
			img.color = c;
			img = GameObject.Find ("WakePanel").GetComponent<Image> ();
			img.color = c;
			img = GameObject.Find ("MixPanel").GetComponent<Image> ();
			img.color = c;
			img = GameObject.Find ("FoodPanel").GetComponent<Image> ();
			img.color = c;
			img = GameObject.Find ("LightPanel").GetComponent<Image> ();
			img.color = c;
			img = GameObject.Find ("HeatPanel").GetComponent<Image> ();
			img.color = c;
			RandomPrompt.killEvent = false; 
			RandomPrompt.wakeEvent = false;
			RandomPrompt.mixEvent = false; 
			RandomPrompt.foodEvent = false; 
			RandomPrompt.lightEvent = false; 
			RandomPrompt.heatEvent = false; 
			penalty (Random.Range (2, 4));
		}
//			if (RandomPrompt.killEvent) {
//				
//			
//
//			} else if (RandomPrompt.wakeEvent) {
//				
//
//				penalty (Random.Range (2, 4));
//			} else if (RandomPrompt.mixEvent) {
//				
//
//				penalty (Random.Range (2, 4));
//			} else if (RandomPrompt.foodEvent) {
//				
//
//				penalty (Random.Range (2, 4));
//			} else if (RandomPrompt.lightEvent) {
//				
//
//				penalty (Random.Range (2, 4));
//			} else {
//				
//				penalty (Random.Range (2, 4));
//			}
	}

	void penalty (int x)
	{
		GameObject[] gos = GameObject.FindGameObjectsWithTag ("snake");
		int numSnakes = gos.Length; 
		for (int i = 0; i < x-1; i++) {
			if (GameObject.FindGameObjectWithTag ("snake") != null) { 
				Destroy (gos [i]);
			} else {
				PlayerPrefs.SetInt ("Score", 0);
				SceneManager.LoadScene ("GameEnd");
			}
		}
	}
}
