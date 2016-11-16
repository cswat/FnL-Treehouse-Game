using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {

	[SerializeField]
	private GameObject pickupPrefab;

	void OnTriggerEnter(Collider other) {
		// If the Collider other is tagged with "Player"...
		if (other.CompareTag ("Player")) {
			//...add the pickup particles...
			Instantiate (pickupPrefab, transform.position, Quaternion.identity);
			FlySpawner.totalFlies--;
			ScoreCounter.score++;
			Destroy (gameObject);
		}
	}
}