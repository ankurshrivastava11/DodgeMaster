using UnityEngine;
using System.Collections.Generic;
using System;
using System.IO;

public class switchLanes : MonoBehaviour{
	// Use this for initialization

	public static int score;

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		score = 0;
	}

	// Update is called once per frame
	void Update () {
		float currentValue = this.transform.position.x + Input.acceleration.x;
		if (currentValue > -7 &&  currentValue < 6.5 ) {
			transform.Translate((Input.acceleration.x * 0.5f), 0, 0);
		}

	}
}