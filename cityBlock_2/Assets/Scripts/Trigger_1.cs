using UnityEngine;
using System.Collections;

public class Trigger_1 : MonoBehaviour {
	
	public GameObject aggressiveMan;
	public Transform target;

	public Animator manAnimator;

//	public AudioClip Explosion;
	public AudioClip AnimalFuck;

	public string walkingManAnimation;
	public string idleManAnimation;
	
	public bool walk;

	public float distance;
	public float distanceLimit;


	void Start() {

		walk = false;

	}

	void Update() {

		distance = Vector3.Distance (aggressiveMan.transform.position, target.position);

		if (distance < distanceLimit) {
			walk = false;
			manAnimator.Play (idleManAnimation);
		}

		if (walk == true) {
			manAnimator.Play (walkingManAnimation);
		}

		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		
		aggressiveMan.transform.LookAt (tempPos);
	}

	void OnTriggerEnter() {
		Debug.Log ("Trigger 2 fired");

		walk = true;

		manAnimator.Play (walkingManAnimation);

		aggressiveMan.audio.PlayOneShot (AnimalFuck);

		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);

		aggressiveMan.transform.LookAt (tempPos);

	}
}
