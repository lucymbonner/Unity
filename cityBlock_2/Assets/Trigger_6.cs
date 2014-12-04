using UnityEngine;
using System.Collections;

public class Trigger_6 : MonoBehaviour {

	public GameObject blueBroScowl;
	public Transform target;
	public AudioClip workJeans;
//	public bool talkScowl;

	void OnTriggerEnter() {
		Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z);
		blueBroScowl.transform.LookAt (tempPos);
		blueBroScowl.audio.PlayOneShot (workJeans);
	}
}
