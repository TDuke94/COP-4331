using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Debugger

public class Controls : MonoBehaviour 
{
	public Text count;
	public Rigidbody2D rb;
	public float movespeed;
	public float xMin, xMax;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		count.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.LeftArrow))
			rb.velocity = new Vector2 (-movespeed, rb.velocity.y);
		if (Input.GetKey (KeyCode.RightArrow))
			rb.velocity = new Vector2 (movespeed, rb.velocity.y);

		rb.position = new Vector2 (Mathf.Clamp (rb.position.x, xMin, xMax), 2.0f);
	}
		
}
	
	