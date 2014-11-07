using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	void OnTriggerEnter(Collider coll) {
		Target target = coll.GetComponent<Target>();
		if (target != null) {
			target.Activate();
		}
	}

	void OnTriggerExit(Collider coll) {
		Target target = coll.GetComponent<Target>();
		if (target != null) {
			target.Deactivate();
		}
	}

}
