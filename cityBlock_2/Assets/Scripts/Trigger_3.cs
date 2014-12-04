using UnityEngine;
using System.Collections;

public class Trigger_3 : MonoBehaviour {

	public GameObject dudeMan;
	public Transform target;

	public Animator dudeManAnimator;
	
	public AudioClip Number;

	public string walkingManAnimation2;
	public string idleDudeManAnimation;

	public float distance3;
	public float distanceLimit3;

	public bool dudeWalk;

	void Start() {

		dudeWalk = false;

	}
	
	
	void Update() {

		Vector3 targetPos = new Vector3(target.position.x, 0, target.position.z);
		
		dudeMan.transform.LookAt (targetPos);
		
		distance3 = Vector3.Distance (dudeMan.transform.position, target.position);
		
		if (distance3 < distanceLimit3) {
			dudeWalk = false;
			dudeManAnimator.Play (idleDudeManAnimation);
		}

		if (dudeWalk == true) {
			dudeManAnimator.Play (walkingManAnimation2);
		}
		
	}
	
	
	void OnTriggerEnter() {
		Debug.Log ("Trigger 3 fired");

		dudeWalk = true;
		
		dudeMan.audio.PlayOneShot (Number);
		
		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		
		dudeMan.transform.LookAt (tempPos);
	}
}
