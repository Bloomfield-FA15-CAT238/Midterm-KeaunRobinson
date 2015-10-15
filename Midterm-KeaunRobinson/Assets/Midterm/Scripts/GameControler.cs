using UnityEngine;
using System.Collections;

public class GameControler : MonoBehaviour {

	public float timer = 0.0f;
	public float xpos = 0.0f;
	public float ypos = 0.0f;
	public float zpos = 0.0f;
	public static  bool moveRight = false;
	public static bool moveLeft =  false;
	public static bool moveBack = false;
	public static bool moveFoward = false;
	public GameObject cylinder;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (moveRight = Input.GetKey(KeyCode.D)){
		    xpos += 1;
			Transform.localPosition = new Vector3(xpos, 0.0f, 0.0f);
		}

		if (moveLeft = Input.GetKey(KeyCode.A)){
			xpos -= 1;
			Transform.localPosition = new Vector3 (xpos, 0.0f, 0.0f);
		}

		if (moveBack = Input.GetKey(KeyCode.S)){
			xpos -= 1;
			Transform.localPosition = new Vector3 (xpos, 0.0f, 0.0f);
		}

		if (moveFoward = Input.GetKey(KeyCode.W)){
			xpos += 1;
			Transform.localPosition = new Vector3 (xpos, 0.0f, 0.0f);
		}



	}

	//public void Respawn(){
	//	cylinder.gameObject.transform.position = respawn.transform.position;
	//}
}
