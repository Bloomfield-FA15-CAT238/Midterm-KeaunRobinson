using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {
	public GameControler gamecontroler;
	public GameObject finishPoint;

	public void OnTriggerEnter(Collider other){
		gamecontroler.WinCondition ();
	}
}
