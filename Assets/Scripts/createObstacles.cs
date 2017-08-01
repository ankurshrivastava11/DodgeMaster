using UnityEngine;
using System.Collections;
using System;

public class createObstacles : MonoBehaviour {
	public float nextTime;
	public GameObject obstacle;

	// Use this for initialization
	void Start () {
		nextTime = Time.time;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > nextTime) {
			
			GameObject newObstacle = Instantiate (obstacle, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
			nextTime += 5.0f;
		}
	}
}