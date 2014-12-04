using UnityEngine;
using System.Collections;

public class redShirtTrigger : MonoBehaviour {

	public Trigger_5 trigger5Script;

	void OnTriggerEnter(Collider Obj) {

		if (Obj.tag == "Player") {
			trigger5Script.talkRedShirt = true;
		}
	}
}
