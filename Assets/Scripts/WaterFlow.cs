using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour {

	private BoxCollider c;

	// Use this for initialization
	void Start () {
		c = GetComponent<BoxCollider> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {

			StartCoroutine("ActivatePower");

		}
	}

	void OnCollisionEnter(Collision c){
	
			if (c.gameObject.tag == "ring") {

				foreach (ContactPoint contact in c.contacts)
					c.gameObject.GetComponent<Rigidbody> ().AddForceAtPosition (new Vector3 (25, 50, 0), contact.point);
			}
	}

	IEnumerator ActivatePower(){
		
		c.enabled = true;
		yield return new WaitForSeconds(1);
		c.enabled = false;
	
	}

}
