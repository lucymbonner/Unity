using UnityEngine;
using System.Collections;

public class Trigger_1 : MonoBehaviour {

	public AudioClip Explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		Debug.Log ("Trigger fired");

		audio.PlayOneShot (Explosion);
	}
}
