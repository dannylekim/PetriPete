using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comboScript : MonoBehaviour
{

	public Text comboText;
	public static float combo = 1;

	void Start ()
	{
	}

	void Update ()
	{
		
		comboText.text = "COMBO:" + combo.ToString () + "X"; 

	}
}

