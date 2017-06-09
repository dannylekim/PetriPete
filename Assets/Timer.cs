using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public Text timerText;
	private float startTime;
	public float t = 0f;

	void Start ()
	{
		startTime = Time.time;
		if (PlayerPrefs.GetFloat ("mode") == null) {
			PlayerPrefs.SetFloat ("mode", 20f);
		}
	}

	void Update ()
	{
		t = Time.time - startTime; //works in seconds!

		float realtime = PlayerPrefs.GetFloat ("mode") - t;
		if (realtime < 0) {
			PlayerPrefs.SetInt ("Score", calculateScore.score);
			SceneManager.LoadScene ("GameEnd");
		}
		string minutes = ((int)realtime / 60).ToString (); 
		string seconds = ((int)realtime % 60).ToString ();

		timerText.text = minutes + ":" + seconds;
	}
}
