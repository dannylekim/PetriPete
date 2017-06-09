using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour {
	public GameObject bact;
	private int numberofbact = 0;
	int startNumBact = Random.Range(1,4);
		
	// Use this for initialization
	void Start () {
		for (int i = 0; i < startNumBact; i++) {
			Instantiate (bact);
			numberofbact++;
		}
		Debug.Log ("Spawned" + numberofbact);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
