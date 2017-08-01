using UnityEngine;
using System.Collections.Generic;
using System;
using System.IO;


public class WriteDataToFile : MonoBehaviour {
	
	private Gyroscope gyro;
	private bool isGyro = false;
	private static List<string> map_data= new List<string>();
	private static string fileName = "gyroscope.txt";
	// Use this for initialization
	void Start () {
		

		if (SystemInfo.supportsGyroscope) {
			gyro = Input.gyro;
			gyro.enabled = true;
			isGyro = true;
		}
	}

	// Update is called once per frame
	void Update () {
		
		if (isGyro) {

			Debug.Log ("Value for Gyro Scope" + gyro.attitude);

			//string s = gyro.attitude.ToString();
			map_data.Add(gyro.attitude.ToString());

		}

		string[] StrList = map_data.ToArray();

		try
		{
			Debug.Log("Before file open");


			if (!File.Exists(fileName))
			{


				Debug.Log("About to write into file!");
				File.WriteAllLines(Application.persistentDataPath+fileName,StrList);
			}
			else
			{
				Debug.Log("About to write into file!");
				File.WriteAllLines(Application.persistentDataPath+fileName,StrList);
			}


		}
		catch (System.Exception e)
		{
			Debug.Log(e);
		}
	}

}