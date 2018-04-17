using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImer : MonoBehaviour {
	float timeRemaining = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}
	void OnGUI(){
		if(timeRemaining > 0){
			GUI.Label (new Rect( 100, 100, 200, 100), "Time Left: " + timeRemaining);
		}
		else {
			GUI.Label(new Rect(100, 100, 100, 100), "Time is Upe"); 
		}
	}

}
