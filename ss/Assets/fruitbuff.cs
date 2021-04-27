using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitbuff : MonoBehaviour {
	public GameObject Apple, Kiwi, Strawberry, Banana, Pear ;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//-----Apple - Gives +1 run speed
		if (Vector3.Distance (transform.position, Apple.transform.position) < 2f) {
			//GetComponent<RigidbodyFirstPersonController>().runmultiplier +1;
		}

		//-----Kiwi - Slows Banana by 1
		if (Vector3.Distance (transform.position, Kiwi.transform.position) < 2f) {

		}

		//-----Strawberry - widens flashlight
		if (Vector3.Distance (transform.position, Strawberry.transform.position) < 2f) {

		}

		//-----Banana - Ends Game when all 5 fruits are collected
		if (Vector3.Distance (transform.position, Banana.transform.position) < 2f) {

		}

		//-----Pear - Gives +1 run speed
		if (Vector3.Distance (transform.position, Pear.transform.position) < 2f) {

		}
	}
}


//-----Buff List
//-----Apple - Gives +1 run speed
//-----Kiwi - Slows Banana by 1
//-----Strawberry - widens flashlight
//-----Banana - Ends Game when all 5 fruits are collected
//-----Pear - Gives +1 run speed