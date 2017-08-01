using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour {

	public int cameraLane;
	public GameObject gvr;
	public TextMesh scoreLabel;

	// Use this for initialization
	void Start () {
		gvr = GameObject.Find("GvrViewerMain");
		GameObject scoreObject = GameObject.Find ("scoreLabel");
		scoreLabel = scoreObject.GetComponent ("TextMesh") as TextMesh;
		cameraLane = 2;

		var oldZ = this.transform.position.z + 100.0f;
		int num = Random.Range (1, 4);
		if (num == 1) {
			this.transform.position = new Vector3 (-5.0f, 0f, oldZ - 1.0f);
		} else if (num == 2) {
			this.transform.position = new Vector3 (-0.0f, 0f, oldZ - 1.0f);
		} else {
			this.transform.position = new Vector3 (5.0f, 0f, oldZ - 1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		float cameraX = gvr.transform.position.x;
		if (cameraX < -2.5f) {
			cameraLane = 1;
		} else if (cameraX > 2.5f) {
			cameraLane = 3;
		} else {
			cameraLane = 2;
		}

		var oldX = this.transform.position.x;
		var oldZ = this.transform.position.z;
		this.transform.position = new Vector3 (oldX, 0f, oldZ - 1.0f);



		if (this.name == "Truck(Clone)") {
			if (oldZ < -150.0f) {
				Destroy (this.gameObject);
			}else if (oldZ < -53.0f && oldZ > -54.5f) {
				if (oldX == -5.0f && cameraLane == 1) {
					Debug.Log ("Collision on lane 1");
				} else if (oldX == 5.0f && cameraLane == 3) {
					Debug.Log ("Collision on lane 3");
				} else if (oldX == 0 && cameraLane == 2) {
					Debug.Log ("Collision on lane 2");
				}
			}
		} else if (this.name == "USD(Clone)") {
			if (oldZ < -150.0f) {
				Destroy (this.gameObject);
			}else if (oldZ < -54.5f && oldZ > -56.0f) {
				if (oldX == -5.0f && cameraLane == 1) {
					Debug.Log ("Point on lane 1");
					int score = switchLanes.score;
					score++;
					scoreLabel.text = "Score: " + score;
					switchLanes.score = score;
					Destroy (this.gameObject);
				} else if (oldX == 5.0f && cameraLane == 3) {
					Debug.Log ("Point on lane 3");
					int score = switchLanes.score;
					score++;
					scoreLabel.text = "Score: " + score;
					switchLanes.score = score;
					Destroy (this.gameObject);
				} else if (oldX == 0 && cameraLane == 2) {
					Debug.Log ("Point on lane 2");
					int score = switchLanes.score;
					score++;
					scoreLabel.text = "Score: " + score;
					switchLanes.score = score;
					Destroy (this.gameObject);
				}
			}
		}
	}
}
