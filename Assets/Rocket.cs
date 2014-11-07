using UnityEngine;
using System.Collections.Generic;

public class Rocket : MonoBehaviour {
	
	public Vector3 velocity;
	public GameObject explosion;
	public List<ParticleEmitter> pses;

	// Explosion properties
	public float explosionPower = 0;
	public float explosionRadius = 0;

	// Update is called once per frame
	void Update () {
		this.transform.position += velocity * Time.deltaTime;
	}

	void OnCollisionEnter(Collision coll) {
		// Create the explosion!
		Instantiate(explosion, transform.position, Quaternion.identity);

		// Detach the particle emitters
		foreach ( ParticleEmitter ps in pses ) {
			ps.emit = false;
			ps.transform.parent = null;
			Destroy(ps.gameObject, 10);
		}

		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
		foreach (Collider hit in colliders) {
			if (hit && hit.rigidbody)
				hit.rigidbody.AddExplosionForce(explosionPower, explosionPos, explosionRadius, 3.0f);
		}

		// Destroy the rocket
		Destroy(gameObject);
	}
}
