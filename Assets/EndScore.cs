using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{

	public Text endScoreText;

	void Start ()
	{
		endScoreText.text = "Score:" + PlayerPrefs.GetInt ("Score").ToString ();
	}

	void Update ()
	{
	}
}

