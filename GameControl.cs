using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour 
{

	// Use this for initialization
	public GameObject Rock; // This should probably be a class of it's own. 
	public Vector2 spawnValues;

	void Start () 
	{
		SpawnWaves ();
	}

	void SpawnWaves()
	{
		Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (Rock, spawnPosition, spawnRotation);
		GUI.Label (new Rect (0, 0, 500, 500), "YEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE!");
	}
	// Update is called once per frame
	void Update () 
	{

	}
}