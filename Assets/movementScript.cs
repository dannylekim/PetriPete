using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{

	private float maxX = 4f;
	private float minX = -6.5f;
	private float maxY = 2.5f;
	private float minY = -3.5f;
	private float movementSpeed = 1;

	private float tChange = 0;
	// force new direction in the first Update
	private float randomX;
	private float randomY;
	public Vector3 val;

	public void Update ()
	{
		// change to random direction at random intervals
		if (Time.time >= tChange) {
			randomX = Random.Range (-2.0f, 2.0f); // with float parameters, a random float
			randomY = Random.Range (-2.0f, 2.0f); //  between -2.0 and 2.0 is returned
			// set a random interval between 0.5 and 1.5
			tChange = Time.time + Random.Range (0.5f, 1.5f);
		}
		transform.Translate (new Vector3 (randomX, randomY, 0) * movementSpeed * Time.deltaTime);
		// if object reached any border, revert the appropriate direction
		if (transform.position.x >= maxX || transform.position.x <= minX) {
			randomX = -randomX;
		}
		if (transform.position.y >= maxY || transform.position.y <= minY) {
			randomY = -randomY;
		}
		// make sure the position is inside the borders
		 

		val.x = Mathf.Clamp (transform.position.x, minX, maxX);
		val.y = Mathf.Clamp (transform.position.y, minY, maxY);
		transform.position = val;

	}
}