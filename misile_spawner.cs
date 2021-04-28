using UnityEngine;
using System.Collections;

public class misile_sawner : MonoBehaviour {

	public GameObject enemyPrefab;

	public float spawnDistance = 12f;

	public float enemyRate = 5;
	public float nextEnemy = 1;

	// Update is called once per frame
	void Update () {
		nextEnemy -= Time.deltaTime;

		if(nextEnemy <= 0) {
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;
			if(enemyRate < 2)
				enemyRate = 2;

			Vector3 offset = Random.onUnitSphere;
				
			offset.z = 0;

			offset = offset.normalized * spawnDistance;

			Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
		}
	}
}
