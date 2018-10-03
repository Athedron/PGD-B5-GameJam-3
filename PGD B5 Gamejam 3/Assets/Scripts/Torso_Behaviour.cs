using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torso_Behaviour : MonoBehaviour
{
	public float moveSpeed = 2f;
	public float rotateSpeed = 200f;

	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();

	}

	void Update()
	{
		
		Move();
	}

	void Move()
	{
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


		transform.Translate(0, 0, z);
		transform.Rotate(0, x, 0);
	}
}