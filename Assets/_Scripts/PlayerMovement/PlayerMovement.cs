using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 100.0f;
	public float rotateSpeed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w")) {
			transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey ("s")) {
			transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey ("d")) {
			transform.Rotate(Vector3.up * rotateSpeed);
			//transform.Translate((Vector3.right) * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate(Vector3.down * rotateSpeed);
			//transform.Translate((Vector3.left) * moveSpeed * Time.deltaTime);
		}
		if(Input.GetButtonDown("Fire1")) {
			Debug.Log("Pressing fire1 key");
			transform.Translate(Vector3.forward);
			Debug.Log("Moved forward");
		}
	}
}
