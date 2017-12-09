using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{

	public float moveSpeed = 10.0f;
	public Rigidbody rb;
	public Camera cam;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		cam = transform.Find ("Main Camera").GetComponent<Camera>();

		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float forward = Input.GetAxis ("Vertical") * moveSpeed;
		float strafe = Input.GetAxis ("Horizontal") * moveSpeed;
		forward *= Time.deltaTime;
		strafe *= Time.deltaTime;

		transform.Translate (strafe, 0, forward);

		float xRotate = Input.GetAxis ("Mouse Y");
		float yRotate = Input.GetAxis ("Mouse X");

		transform.Rotate (0, yRotate, 0);

		cam.transform.Rotate (-xRotate, 0, 0);

//		rb.AddForce (strafe, 0, forward);
	}

}
