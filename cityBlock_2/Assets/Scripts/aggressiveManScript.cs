using UnityEngine;
using System.Collections;

public class aggressiveManScript : MonoBehaviour {

	public Transform target;
	public bool turnToward;

	void Start () {

//		turnToward = false;
	}

	// Update is called once per frame
	void Update () {

		Debug.Log ("man script");

		if (turnToward == true) {

			Debug.Log("turning!");

//			Vector3 tempPos = new Vector3 (0, target.position.y, 0); //this will only affect the y axis, you can shuffle the values around to make it only x or only z or a combination of any.
			Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);


			transform.LookAt (tempPos);
		}
	}
}
