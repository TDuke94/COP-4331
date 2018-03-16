using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMotion : MonoBehaviour 
{
	public float speed;
	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (0.0f, speed);
	}

	void Update()
	{
		rb.velocity = new Vector2 (0.0f, speed);
		if (rb.position.y > 100)
			Destroy (gameObject);
	}
}
