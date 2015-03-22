using UnityEngine;
using System.Collections;

public class CT : MonoBehaviour {

	public float Accele = 1.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(
			transform.right*Input.GetAxisRaw("Horizontal")*Accele,ForceMode.Impulse);
	}
}
