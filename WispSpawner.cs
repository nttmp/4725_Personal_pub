using UnityEngine;
using System.Collections;

public class WispSpawner : MonoBehaviour {

	public GameObject wisp1;
	public GameObject wisp2;
	private bool activated;

	// Use this for initialization
	void Start () {
		activated = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (!activated) {
			if (other.tag == "Player") {
				wisp1.SetActive(true);
				wisp2.SetActive(true);
				activated = true;
			}
		}
	}
}
