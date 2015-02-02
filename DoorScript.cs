using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	private float timer;
	public GameObject target;
	private bool countdown;
	public AudioSource sound;
	private bool soundPlayed;

	public GameObject gameController;

	public GameObject g1;
	public GameObject g2;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
		soundPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (countdown) {
			timer += Time.deltaTime;
			if (timer >= 3.5f) {
				g1.SetActive(false);
				g2.SetActive(false);
				gameController.GetComponent<GameSceneController>().hide();

			}
			if (timer >= 5.0f) {
				transform.LookAt(target.transform);
				if (!soundPlayed) {
					sound.Play ();
					soundPlayed = true;
				}

			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			countdown = true;
		}
	}
}
