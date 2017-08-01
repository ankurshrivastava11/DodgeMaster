using UnityEngine;
using System.Collections;
using System;

public class createTrees : MonoBehaviour {
	public float nextTime;
	public GameObject tree;

	// Use this for initialization
	void Start () {
		nextTime = Time.time;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > nextTime) {

			GameObject newTree = Instantiate (tree, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
			nextTime += 1.0f;
		}
	}
}
