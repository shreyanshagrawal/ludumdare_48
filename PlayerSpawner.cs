using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerSpawner : MonoBehaviour {

	public GameObject playerPrefab;
	GameObject playerInstance;
	public TextMeshProUGUI deathText;
	public TextMeshProUGUI healthText;

	public int numLives = 4;
	public int x;
	float respawnTimer;

	// Use this for initialization
	void Start () {
		SpawnPlayer();
	}

	void SpawnPlayer() {
		numLives--;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInstance == null && numLives > 0) {
			respawnTimer -= Time.deltaTime;

			if(respawnTimer <= 0) {
				SpawnPlayer();
			}
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(x);
		}
		if (numLives > 0 || playerInstance != null)
		{
			healthText.text = "Health : " + numLives;
		}
		else
		{
			//soundManager.PlaySound("death");
			deathText.enabled = true;
			deathText.gameObject.SetActive(true);
            
		}
	

}

	
		
}

/*
 if(numLives > 0 || playerInstance!= null) {
			GUI.Label( new Rect(0, 0, 100, 50), "Lives Left: " + numLives);
		}
		else {
			//soundManager.PlaySound("death");
			GUI.Label( new Rect( Screen.width/2 - 50 , Screen.height/2 - 25, 100, 50), "Game Over, Man!");

		}
	}
 */
