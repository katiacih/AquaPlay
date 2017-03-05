using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RingsGenerator : MonoBehaviour {
	private float alturaMin, alturaMax,eixoY,eixoX;
	public GameObject ring;
	private Vector3 position;
	public RingController rC;
	private Ringmodel rM;



	//em x = -14 a 14 e em y = 0.53 a 11
	// Use this for initialization
	void Start () {
		rC.rings = new List<Ringmodel> ();
		alturaMin = 0.53f;
		alturaMax = 11.0f;
		for (int i = 0; i < 10; i++){
			//setar position random
			eixoY = Random.Range(alturaMin,alturaMax);
			eixoX = Random.Range (-14, 14);
		    position = new Vector3 (eixoX, eixoY, 2.75f);
			Instantiate (ring, position,ring.transform.localRotation);
			rM.id = i;
			rM.status = false;
			rC.rings.Add (rM);

		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
