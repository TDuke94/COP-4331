using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour {

	// Initialize does nothing
	void Start () {
		
	}

	// Upon trigger collision with another game object, both die
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.name);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
