using UnityEngine;
using System.Collections;

public class MoveMalcolm : MonoBehaviour {

//	float forwardRate = 3f;
//	float turnRate = 4f;
	int moveBehaviour = 0;
	private Animator anim;
	Rigidbody r;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			moveBehaviour = 3;
		} else if (Input.GetKey (KeyCode.D)) {
			moveBehaviour = 2;
		} else if (Input.GetKey (KeyCode.W)) {
			moveBehaviour = 1;
		} else {
			moveBehaviour = 0;
		}
		anim.SetInteger ("move", moveBehaviour);
//		float forwardMoveAmount = Input.GetAxis ("Vertical") * forwardRate;
//		float turnForce = Input.GetAxis ("Horizontal") * turnRate;
//		transform.Rotate (0, turnForce, 0);
//		transform.position += transform.forward * forwardMoveAmount * Time.deltaTime;
	}
		
	void OnCollisionEnter (Collision c) {
		if (c.gameObject.CompareTag ("Object")) {
			anim.Play("Idle");
		}
	}
}
