using UnityEngine;
using System.Collections;

public class GameSceneController : MonoBehaviour {

	public GameObject g1;
	public GameObject g2;
	public GameObject g3;
	public GameObject g4;
	public GameObject g5;
	public GameObject g6;

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	public Camera camera5;

	private bool hiding;
	public bool finished;
	//TO DO: zones if needed;


	// Use this for initialization
	void Start () {
		//g1.SetActive (false);
		//g2.SetActive (false);
		g3.SetActive (false);
		g4.SetActive (false);
		g5.SetActive (false);
		g6.SetActive (false);
		hiding = false;
		finished = false;
	}
	
	// Update is called once per frame
	void Update () {

		//Hiding
		if (camera1.active == true || camera2.active == true || camera3.active == true ||
			camera4.active == true || camera5.active == true) {

			hiding = true;
		}
		else {
			hiding = false;
		}

		if (hiding) {
			hide ();
		}

		if (finished) {
			if (Input.GetKeyDown("r")) {
				Application.LoadLevel("Main_v4");
			}
		}
	
	}

	public void hide() {

//		if (g1.GetComponent<WispMover>().move == true) {
//			g1.SetActive (false);
//		}
//		if (g2.GetComponent<WispMover>().move == true) {
//			g2.SetActive (false);
//		}
//		if (g3.GetComponent<WispMover>().move == true) {
//			g3.SetActive (false);
//		}
//		if (g4.GetComponent<WispMover>().move == true) {
//			g4.SetActive (false);
//		}
//		if (g5.GetComponent<WispMover>().move == true) {
//			g5.SetActive (false);
//		}

		g1.SetActive (false);
		g2.SetActive (false);
		g3.SetActive (false);
		g4.SetActive (false);
		//g5.SetActive (false);

	}
}
