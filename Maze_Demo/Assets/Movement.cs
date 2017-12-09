using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{

	public float moveSpeed = 10.0f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float forward = Input.GetAxis ("Vertical") * moveSpeed;
		float strafe = Input.GetAxis ("Horizontal") * moveSpeed;
		forward *= Time.deltaTime;
		strafe *= Time.deltaTime;

		transform.Translate (strafe, 0, forward);

//		rb.AddForce (strafe, 0, forward);
	}

}
