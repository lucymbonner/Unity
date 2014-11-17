using UnityEngine;
using System.Collections;

public class Trigger_2 : MonoBehaviour {

	public GameObject intimidatingMan;
	public GameObject intimidatingMan2;
	public GameObject dudeBro;
	public Transform target;

	public Animator intimidatingManAnimator;

//	public AudioClip Explosion2;
	public AudioClip fatAsses;
	public AudioClip complimentThanks;
	public AudioClip Mmm;
	
	public string idleManAnimation;

	public float distance2;
	public float distanceLimit2;

	public bool talkTo;


	void Start() {

		talkTo = false;

	}

	void Update() {

		distance2 = Vector3.Distance (intimidatingMan.transform.position, target.position);
		
		if (distance2 > distanceLimit2) {
			talkTo = false;
			intimidatingManAnimator.Play (idleManAnimation);
		}

		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		
		intimidatingMan.transform.LookAt (tempPos);
		intimidatingMan2.transform.LookAt (tempPos);
		dudeBro.transform.LookAt (tempPos);

		if (talkTo == true) {
			intimidatingMan2.audio.PlayDelayed (1);
			dudeBro.audio.PlayDelayed(2);
		}
	}

	
	void OnTriggerEnter() {
		Debug.Log ("Trigger 2 fired");

		talkTo = true;
		
		intimidatingMan.audio.PlayOneShot (fatAsses);
		
	}
}
