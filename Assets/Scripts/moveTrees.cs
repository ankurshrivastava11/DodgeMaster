using UnityEngine;
using System.Collections;

public class moveTrees : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var oldZ = this.transform.position.z;
		this.transform.position = new Vector3(-0.451f, 0.0f, oldZ - 0.4f);
		if (oldZ < -150.0f) {
			Destroy (this.gameObject);
		}
	}
}
