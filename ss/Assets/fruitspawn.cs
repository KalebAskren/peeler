using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fruitspawn : MonoBehaviour {
	public GameObject apple, kiwi, strawberry, peeledbanana, pear;

	//GameObject fruit = { apple, kiwi, strawberry, peeledbanana, pear };
	Vector3[] pos = new Vector3[5];

	//x -> 425 to 45
	//y -> 82
	//z -> 84 to 442
	// Use this for initialization

	void Start () {
		for (int i = 0; i < 5; i++) {
			//Random rnd = new Random ();
			int x = Random.Range (45, 425);
			int z = Random.Range (84, 442);
			pos [i] = new Vector3 (x, 82, z);

		}

		for (int i = 0; i < 5; i++) {
			instantiatefruit (i, pos [i]);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void instantiatefruit(int id, Vector3 position)
	{
		GameObject temp = new GameObject();
		if (id == 0) {
			temp = Instantiate (apple);
		}
		if (id == 1) {
			temp = Instantiate (kiwi);
		}
		if (id == 2) {
			temp = Instantiate (strawberry);
		}
		if (id == 3) {
			temp = Instantiate (peeledbanana);
		}
		if (id == 4) {
			temp = Instantiate (pear);
		}
		temp.transform.position = position;
	}
}

