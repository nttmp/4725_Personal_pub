using UnityEngine;
using System.Collections;

//This script will switch to a static camera at the press of a button
//when the player is in the collision zone

public class CameraSwitcher : MonoBehaviour {

	
	private bool switchable; //Control the switch hotkey state.
	private bool inStaticCam; //Track if the static camera is the current active camera.
	public Camera staticCam; //The alternate camera that the view will switch to.
	public GameObject playerObject; //The character controller. Will be disabled.

	public GameObject gameController;

	// Use this for initialization
	void Start () {
		switchable = false;
		inStaticCam = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (switchable == true) {
			if (Input.GetKeyDown("e")) {
				Debug.Log ("e");
				if (staticCam.active == false) {
					Debug.Log ("false");
					playerObject.active = false;
					staticCam.active = true;
					//inStaticCam = true;

				}
				else if (staticCam.active == true) {
					Debug.Log ("true");
					playerObject.active = true;
					staticCam.active = false;
					//inStaticCam = false;
				}
			}
		}

	}//Update

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Trigger Entered");
		if (other.tag == "Player") {
			switchable = true;
			Debug.Log ("Player Entered zone");
		}
	}
	
	void OnTriggerExit(Collider other) {
		Debug.Log ("Trigger exited");
		if (other.tag == "Player") {
			switchable = false;
			Debug.Log ("Plyer Exited zone");				
		}
	}
}

