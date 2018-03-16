using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb;

	// Motion Controls
	public float movespeed;
	public float xMin, xMax;

	// Fire Controls
	public float fireRate;
	private float nextFire;
	public GameObject Shot;
	private Vector3 shotSpawn;

	// Initialize PlayerController
	// Get reference to Parent GameObject 2D RigidBody
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
		{
			// update next fire time
			nextFire = Time.time + fireRate;

			// determine shot start location
			// Start location should be slightly in front of the ship
			shotSpawn = new Vector3(rb.position.x, rb.position.y + 2.0f);

			// Instantiate the shot
			// identity Quaternion corresponds with no rotation
			Instantiate(Shot, shotSpawn, Quaternion.identity);
		}
	}

	/* FixedUpdate occurs per frame
	 * Tasks per update:
	 * 		Get key
	 * 		use key to update velocity
	 * 		restrict movement by boundaries
	 */
	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.LeftArrow))
			rb.velocity = new Vector2 (-movespeed, rb.velocity.y);
		if (Input.GetKey (KeyCode.RightArrow))
			rb.velocity = new Vector2 (movespeed, rb.velocity.y);

		// Boundaries are defined outside of script
		// 0.0f is fixed y position of player ship
		rb.position = new Vector2 (Mathf.Clamp (rb.position.x, xMin, xMax), 0.0f);

	}
}
