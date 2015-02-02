using UnityEngine;
using System.Collections;

public class WakeUp : MonoBehaviour {

	public GameObject topLid;
	public GameObject bottomLid;
	public GameObject wakeUpCamera;
	public GameObject player;
	public float speed;
	float timer;
	public float deleteTime; //This is the time that the lid objects should be disabled.
	bool openLids;
	public AudioSource gasp;

	// Use this for initialization
	void Start () {
		openLids = false;
		speed = speed * Time.deltaTime;
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("w")) {
			openLids = true;
			gasp.Play();
		}

		if (openLids) {
			topLid.transform.Translate(Vector3.forward * speed);
			bottomLid.transform.Translate(Vector3.back * speed);
			timer += Time.deltaTime;
		}

		if (timer >= deleteTime) {
			topLid.SetActive(false);
			bottomLid.SetActive(false);
			wakeUpCamera.SetActive(false);
			player.SetActive(true);
		}
	}
}
