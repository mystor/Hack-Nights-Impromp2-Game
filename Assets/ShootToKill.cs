using UnityEngine;
using System.Collections;

public class ShootToKill : MonoBehaviour {

	public GameObject rocket_prefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Rocket rocket = (Instantiate(rocket_prefab, transform.position + Vector3.up, transform.rotation) as GameObject).GetComponent("Rocket") as Rocket;
			rocket.velocity = Camera.main.transform.forward * 30;
			Destroy(rocket.gameObject, 30);
		}
	}
	
}
