using UnityEngine;
using System.Collections;

public class WispMover : MonoBehaviour {

	public GameObject targetObject; //The endpoint object.
	public GameObject player;
	public GameObject wp1; //Optional gameobjects to be used as waypoints
	public GameObject wp2; //"" 									""
	public float movementSpeed;
	private Vector3 startingPosition;
	private float distanceBetween;
	public float movementThreshold; //A distance to be passed in. Move forward if more, back if less.
	public bool move;

	// Use this for initialization
	void Start () {
		move = false;
		movementSpeed = movementSpeed * Time.deltaTime;
		startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if(move) {
			distanceBetween = Vector3.Distance(player.transform.position, transform.position);
			Debug.Log (distanceBetween);

			if (distanceBetween >= movementThreshold) {
				transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, movementSpeed);
			}

			if (distanceBetween < movementThreshold) {
				transform.position = Vector3.MoveTowards(transform.position, startingPosition, movementSpeed);
			}

			//Move to the next waypoint if it exists
			if (transform.position == targetObject.transform.position) {
				if (wp1 != null) {
					targetObject = wp1;
				}
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			move = true;
		}
	}
}
