using UnityEngine;
using System.Collections;

public class Trigger_3 : MonoBehaviour {

	public GameObject dudeMan;
	public Transform target;

	public Animator dudeManAnimator;

	public AudioClip Explosion3;
	public AudioClip Number;

	public string walkingManAnimation2;
	public string dudeManAnimation;

//	public float distance3;
//	public float distanceLimit3;
	
	
	void Update() {

		Vector3 targetPos = new Vector3(target.position.x, 0, target.position.z);
		
		dudeMan.transform.LookAt (targetPos);
		
//		distance3 = Vector3.Distance (dudeMan.transform.position, target.position);
//		
//		if (distance3 < distanceLimit3) {
//			dudeManAnimator.Play (dudeManAnimation);
//		}
		
	}
	
	
	void OnTriggerEnter() {
		Debug.Log ("Trigger 3 fired");
		
		dudeMan.audio.PlayOneShot (Number);
		
		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		
		dudeMan.transform.LookAt (tempPos);

		dudeManAnimator.Play (walkingManAnimation2);
	}
}
