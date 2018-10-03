using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs_movement : MonoBehaviour
{
	public float moveSpeed = 5;
	public float jumpSpeed = 0.5f;
	public float rotateSpeed = 200f;

	Rigidbody rb;


	bool isJumping;

	Vector3 jumpPos;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		jumpPos = transform.position;

	}

	void Update()
	{
		
		Move();
	

	}

	void Move()
	{
		float x = Input.GetAxis("Horizontal_Wasd") * Time.deltaTime * rotateSpeed;
		float z = Input.GetAxis("Vertical_Wasd") * Time.deltaTime * moveSpeed;

		if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
		{
			isJumping = true;
			rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
		}
		transform.Translate(0, 0, z);
		transform.Rotate(0, x, 0);
	}



	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.name == "Ground")
		{
			isJumping = false;
		}
	}
}