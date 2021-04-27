using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitchwabbly : MonoBehaviour {
	public GameObject player;
	float curd, prevd;
	public AudioSource spoopy;
	// Use this for initialization
	void Start () {
		prevd = Vector3.Distance (transform.position, player.transform.position);
		
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (transform.position, player.transform.position);
		curd = distance;
		if (curd < 60) {
			if (curd < prevd) {
				//sub fraction from audio
				Debug.Log (curd);
				spoopy.pitch -= 1 / (50 * curd);
			}
			if (curd > prevd) {
				//sub fraction from audio
				if (spoopy.pitch < 1) {
					spoopy.pitch += 1 / (50 * curd);
					Debug.Log (curd);
				}
			}
		}
		prevd = curd;
	}
}
