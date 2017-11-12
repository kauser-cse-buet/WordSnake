using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Letter")) {
			other.gameObject.SetActive (false);	
			count = count + 1;
		}
	}
}
