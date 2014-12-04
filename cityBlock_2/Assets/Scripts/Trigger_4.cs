using UnityEngine;
using System.Collections;

public class Trigger_4 : MonoBehaviour {

	public GameObject oldManSuit;
	public GameObject greasyGuy;

	public Transform target;

	public Animator oldManSuitAnimator;
	public Animator greasyGuyAnimator;

	public AudioClip Smile1;
	public AudioClip bitchesGood;

	public string idleGreasyGuyAnimation;
	public string walkingGreaseBall;
	public string walkingBackwardGreaseBall;

	public float distance4;
	public float distanceLimit4;

	public bool talking;
	public bool greaseWalk;


	void Start() {

		talking = false;
		greaseWalk = false;

	}
	
	void Update() {

		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		Vector3 tempPosGuy = new Vector3((target.position.x + 3), 0, (target.position.z + 3));
		
		oldManSuit.transform.LookAt (tempPos);
		greasyGuy.transform.LookAt (tempPos);

		distance4 = Vector3.Distance (greasyGuy.transform.position, target.position);
		
		if (distance4 < distanceLimit4) {
			talking = false;
			greaseWalk = false;
			greasyGuyAnimator.Play (idleGreasyGuyAnimation);
		}

		if (greaseWalk == true) {
			greasyGuyAnimator.Play(walkingGreaseBall);
		}

		if (talking == true) {
			greasyGuy.audio.PlayDelayed (1);
		}

	}

	void OnTriggerEnter() {
		Debug.Log ("Trigger 4 fired");

		talking = true;
		greaseWalk = true;

		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		
		oldManSuit.transform.LookAt (tempPos);
		greasyGuy.transform.LookAt (tempPos);
		
		oldManSuit.audio.PlayOneShot (Smile1);
		
	}
}
