using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ringmodel  {

	public bool status{ get; set; }
	public int id { get; set; }

	public Ringmodel (bool status)
	{
		this.status= status;
	}
	// construtor que recebe o nome e a idade
	public Ringmodel (bool status, int id)
	{
		this.status = status;
		this.id = id;
	}
}
