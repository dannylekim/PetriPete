using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculateScore : MonoBehaviour
{

	public Text scoreText;
	public static int score = 0;

	void Start ()
	{
	}

	void Update ()
	{
		score = GameObject.FindGameObjectsWithTag ("snake").Length;
		score++;
		scoreText.text = "SCORE: " + score.ToString ();
	
	}
}

