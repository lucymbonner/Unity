using UnityEngine;
using System.Collections;

public class Trigger_5 : MonoBehaviour {

	public GameObject redShirt;
	public Transform endPoint;
	public Transform target;

	public Animator redShirtAnimator;

	public string walkingRedShirt;
	public string idleRedShirt;

//	public float distance5;
	public float distanceLimit5;
	public float endPointDistance;

	public bool talkRedShirt;
	public bool walkRedShirt;


	void Start() {

		talkRedShirt = false;
		walkRedShirt = false;

	}

	void Update() {

//		distance5 = Vector3.Distance (redShirt.transform.position, target.position);

		endPointDistance = Vector3.Distance (redShirt.transform.position, endPoint.position);

		if (endPointDistance < 2) {
			walkRedShirt = false;
		}

		if (walkRedShirt == true) {
			redShirtAnimator.Play (walkingRedShirt);
		} else {
			redShirtAnimator.Play (idleRedShirt);
		}

		if (talkRedShirt == true && redShirt.audio.isPlaying == false) {
			redShirt.audio.Play();
			talkRedShirt = false;
		}

	}

	void OnTriggerEnter() {

		Vector3 tempPos = new Vector3(endPoint.position.x, 0, endPoint.position.z);
		redShirt.transform.LookAt (tempPos);

		walkRedShirt = true;

	}
}
