using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingController {
	public List<Ringmodel> rings;



	ArrayList insertRing (Ringmodel newRing , ArrayList list){
		list.Add (newRing);
		return list;

	}
	ArrayList removeRing (Ringmodel Oldring , ArrayList list){
		list.Remove (Oldring);
		return list;

	}
	Ringmodel getRing (Ringmodel ring , ArrayList list){
		foreach (Ringmodel r in list)
			if (ring.Equals (r)) {
				return ring;
			}
				
		return null;
	}
	bool ContainsRing (Ringmodel ring , ArrayList list){
		if (list.Contains(ring)) {
				return true;
			}
		return false;
	}


}
