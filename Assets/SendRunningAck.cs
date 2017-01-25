using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SendRunningAck : MonoBehaviour {

	float timer;
	Color[] color = new Color[2];
	int index = 0;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		color[0] = Color.blue;
     	color[1] = Color.red;
		cube = GameObject.Find ("Cube");
		cube.GetComponent<Renderer>().material.color = color[index];
		Debug.Log ("Starting the app..");
	}
	
	// Update is called once per frame
	void Update () {
		 timer += Time.deltaTime;
	     if(timer > 2){
	         if(++index == color.Length)index = 0;
			cube.GetComponent<Renderer>().material.color = color[index];
	         timer = 0;
			Debug.Log ("Changing color..", cube);
	     }
	}
}
