using UnityEngine;
using System.Collections;

public class respwan : MonoBehaviour {
	public GameObject respawn;
	public GameControler gameControls;
	// Use this for initialization

	
	void OnTriggerEnter(Collider other)
	{
		//gamecontrolerVariable.Respawn();
			gameControls.Respawn ();
	}
}