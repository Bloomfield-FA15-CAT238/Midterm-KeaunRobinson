using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControler : MonoBehaviour {
	public GameObject spawner, player;
	public float timer;
	public Text letters;
	public Canvas ui;
	public bool gameOn = false;


	// Use this for initialization
	void Start () {
		ui.enabled = true;
		gameOn = true;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (gameOn)
			letters.text = "Current Time: " + timer;
		else
			letters.text = "Your time was " + timer;
	}
		public void Respawn(){
		player.gameObject.transform.position = spawner.transform.position;
		}

		public void WinCondition(){
		gameOn = false;
		Time.timeScale = 0;

	}


	//public void Respawn(){
	//	cylinder.gameObject.transform.position = respawn.transform.position;
	//}
}
