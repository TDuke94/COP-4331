using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour 
{
	private Rigidbody2D rb;
	public float xSpeed;
	public float ySpeed;

	// Initialize Enemy
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		rb.velocity = new Vector2 (xSpeed, ySpeed);

		// Clean up objects which have thoroughly left the screen
		if (rb.position.y < -10.0f)
			Destroy (gameObject);
	}
}
