using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timertext;
	public float playtime;
	float starttime, curtime;

	// Use this for initialization
	void Start () {
		starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		curtime = Time.time;
		playtime = curtime - starttime;
		timertext.text = playtime.ToString ("f2");
	}

	public float gettime(){
		
		return playtime;

	}
}
