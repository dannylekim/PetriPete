using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
	public Text timerText;
	private float startTime;
	public float t = 0;

	void Start () {
		startTime = Time.time;
	}

	void Update (){
		t = Time.time - startTime; //works in seconds!

		float realtime = 60 - t;
		if (realtime < 0) {
			PlayerPrefs.SetInt ("Score", calculateScore.8score);
			Application.LoadLevel ("GameEnd");
		}
		string minutes = ((int) realtime / 60).ToString (); 
		string seconds = ((int) realtime % 60).ToString ();

		timerText.text = minutes + ":" + seconds;
	}
}
