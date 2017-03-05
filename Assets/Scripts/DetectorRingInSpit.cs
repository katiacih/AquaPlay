using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorRingInSpit : MonoBehaviour {

	public string positionContact;
	public Vector3 positionClosest;
	public float TimeStaySpin = 0;
	public bool pontuacao = false;
	public int pontos = 0;
	// count rings




	// Use this for initialization
	void Start () {
		//		rings =  new Hashtable ();



	}

	// Update is called once per frame
	void Update () {
		if (pontuacao == true) {
			pontos= pontos + 1;
			pontuacao = false;
		}

	}
	void OnTriggerEnter(Collider other)
	{
		//para verificar a quantidade de argolas deve-se dividir por 4
		if (other.tag == "spit") {
			positionContact = other.contactOffset.ToString();

		}
	}
	void OnTriggerStay(Collider other){
		if (other.name.Contains("spit")) {
			TimeStaySpin += Time.deltaTime;
			if (TimeStaySpin > 5) {
				pontuacao = true;
				TimeStaySpin = 0;

			}
		}


	}
}

