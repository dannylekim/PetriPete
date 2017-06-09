using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
	public static int score;
	// Use this for initialization
	void Start ()
	{
		// text = GetComponent <Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//text.text = GameObject.FindGameObjectsWithTag ("bacteria").Length;
	}
}
