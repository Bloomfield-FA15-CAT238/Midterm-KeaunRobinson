using UnityEngine;
using System.Collections;

public class respwan : MonoBehaviour {
	public GameObject respawn;
	// Use this for initialization

	
	void OnTriggerEnter(Collider other)
	{
		//gamecontrolerVariable.Respawn();
		other.gameObject.transform.position = respawn.transform.position;
	}
}