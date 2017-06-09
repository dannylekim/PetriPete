using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPrompt : MonoBehaviour
{
	public static bool eventPrompt = false;
	public static bool killEvent = false;
	public static bool mixEvent = false;
	public static bool wakeEvent = false;
	public static bool foodEvent = false;
	public static bool heatEvent = false;
	public static bool lightEvent = false;


	// Use this for initialization
	void Start ()
	{
		randomChooser ();
	}


	// Update is called once per frame
	void Update ()
	{
		if (!eventPrompt) { 
			randomChooser (); 
		}
	}

	void randomChooser ()
	{
		int choose = Random.Range (1, 7);
		if (choose == 1) {
			Image img = GameObject.Find ("KillPanel").GetComponent<Image> ();
			img.color = UnityEngine.Color.yellow; // this is to set the panel to yellow ie lighting it up
			eventPrompt = true; 
			killEvent = true;
			eventTimer.timeLeft = Random.Range (1.0f, 3.0f);
		} else if (choose == 2) {
			Image img = GameObject.Find ("MixPanel").GetComponent<Image> ();
			img.color = UnityEngine.Color.yellow; // this is to set the panel to yellow ie lighting it up
			eventPrompt = true; 
			mixEvent = true;
			eventTimer.timeLeft = Random.Range (1.0f, 3.0f);
		} else if (choose == 3) {
			Image img = GameObject.Find ("WakePanel").GetComponent<Image> ();
			img.color = UnityEngine.Color.yellow; // this is to set the panel to yellow ie lighting it up
			eventPrompt = true; 
			wakeEvent = true;
			eventTimer.timeLeft = Random.Range (1.0f, 3.0f);
		} else if (choose == 4) {
			Image img = GameObject.Find ("HeatPanel").GetComponent<Image> ();
			img.color = UnityEngine.Color.yellow; // this is to set the panel to yellow ie lighting it up
			eventPrompt = true; 
			heatEvent = true;
			eventTimer.timeLeft = Random.Range (1.0f, 3.0f);

		} else if (choose == 5) {
			Image img = GameObject.Find ("LightPanel").GetComponent<Image> ();
			img.color = UnityEngine.Color.yellow; // this is to set the panel to yellow ie lighting it up
			eventPrompt = true; 
			lightEvent = true;
			eventTimer.timeLeft = Random.Range (1.0f, 3.0f);

		} else {
			Image img = GameObject.Find ("FoodPanel").GetComponent<Image> ();
			img.color = UnityEngine.Color.yellow; // this is to set the panel to yellow ie lighting it up
			eventPrompt = true; 
			foodEvent = true;
			eventTimer.timeLeft = Random.Range (1.0f, 3.0f);
		}
	}

}
	