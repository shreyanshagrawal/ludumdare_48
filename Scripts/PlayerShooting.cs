using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bulletPrefab;
	int bulletLayer;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Start() {
		bulletLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;

		if( (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && cooldownTimer <= 0 ) {
			// SHOOT!
			//soundManager.PlaySound("shoot");
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;
		}
	}
}
