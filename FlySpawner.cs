using UnityEngine;
using System.Collections;

public class FlySpawner : MonoBehaviour {

	[SerializeField]
	private GameObject flyPreFab;
	[SerializeField]
	private int totalFlyMinimum = 12;

	private float spawnArea = 25f;

	public static int totalFlies = 25;

	// Use this for initialization
	void Start () {
		totalFlies = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		//while the total number of flies is less than the minimum...
		while (totalFlies < totalFlyMinimum) {

			//...then increment the total number of flies..
			totalFlies++;

			//...create a random position for a fly...
			float positionX = Random.Range(-spawnArea,spawnArea);
			float positionZ = Random.Range(-spawnArea,spawnArea);
			Vector3 flyPosition = new Vector3 (positionX, 2f, positionZ);

			//...and spawn a fly.
			Instantiate(flyPreFab,flyPosition,Quaternion.identity);
		}//while
	}
}
