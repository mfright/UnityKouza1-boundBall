using UnityEngine;
using System.Collections;

public class BallStart : MonoBehaviour {

	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce (
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
