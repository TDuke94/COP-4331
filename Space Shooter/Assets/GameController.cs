using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GameObject Enemy;
	public Vector2 spawnValues;
	public int numOfEnemies;
	public float waitTime;

	IEnumerator Start () 
	{
		return SpawnWaves ();
	}

	IEnumerator SpawnWaves()
	{
		// All enemies are rotated 180 in x to face player
		Quaternion spawnRotation = Quaternion.Euler (180, 0, 0);

		for (int i = 0; i < numOfEnemies; i++)
		{
			// Spawn position is random about range in x, fixed about y
			Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);

			//Instantiate an enemy
			Instantiate (Enemy, spawnPosition, spawnRotation);

			yield return new WaitForSeconds (waitTime);
		}
	}

	// Update Method
	void Update () 
	{

	}
}
