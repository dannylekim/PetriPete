using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAdvanced : MonoBehaviour
{

	private float startTime;
	public int numEnemies = 1;
	private float Rate = .9f;
	//private int Kapacity = 25;
	public static float spawnInterval = 2.0f;
	private float nextSpawn = 0.0f;

	public GameObject enemy;

	// Use this for initialization
	void Start ()
	{
		nextSpawn = Time.time + spawnInterval;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnInterval;
			numEnemies = GameObject.FindGameObjectsWithTag ("snake").Length;
			numEnemies++;
			int MoarEnemies = (int)Rate * numEnemies;
			for (int i = 0; i <= MoarEnemies; i++) {
				float xrand = Random.Range (-4.5f, 4f);
				float yrand = Random.Range (-3.5f, 2.5f);
				GameObject snake = Instantiate (enemy, transform.position + new Vector3 (xrand, yrand, 0), transform.rotation);
				snake.tag = "snake";

			}
		 		
			
		} 
	}
}
