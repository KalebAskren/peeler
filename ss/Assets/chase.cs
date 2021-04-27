using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chase : MonoBehaviour {
	public GameObject player;
	public GameObject banana;
	public Vector3 location;
	public float bananaspeed;
	float px, py, pz, nx, nz;
	float tempx, tempz;
	public AudioSource scream;
	bool isdone1 = false, isdone2 = false, isdone3 = false, isdone4= false;
	//this is the time in minutes that the banana gets faster - the less here the harder
	public float difficulty;

	// Use this for initialization
	void Start () {

		scream.volume = 0;
		
	}
	
	// Update is called once per frame
	private void FixedUpdate(){
		px = player.transform.position.x;
		py = player.transform.position.y;
		pz = player.transform.position.z;

		tempx = banana.transform.position.x - px;
		tempz = banana.transform.position.x - pz;

		transform.LookAt (player.transform.position);
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);
		if(Vector3.Distance(transform.position, player.transform.position) > 1f){
			transform.Translate (new Vector3 (bananaspeed * Time.deltaTime, 0, 0));
		}
		transform.rotation.Set(0,0,90,0); // (new Vector3 (0, 0, 0), Space.Self);
		if (Vector3.Distance (transform.position, player.transform.position) < 3f) {
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			//if (scream.volume < 1) {
				scream.volume += 1 / Vector3.Distance (transform.position, player.transform.position);
			//}
			scream.Play ();
			player.transform.Translate (player.transform.position.x, 155, player.transform.position.y);


		}

		float timep = (banana.GetComponent<timer>().gettime ()) / 60;
		if (timep > difficulty && isdone1 == false) {
			bananaspeed += 1;
			isdone1 = true;
			Debug.Log ("increase in b-speed: " + bananaspeed);
		}

		if (timep > 2*difficulty && isdone2 == false) {
			bananaspeed += 1;
			isdone2 = true;
			Debug.Log ("increase in b-speed: " + bananaspeed);

		}

		if (timep > 3*difficulty && isdone3 == false) {
			bananaspeed += 1;
			isdone3 = true;
			Debug.Log ("increase in b-speed: " + bananaspeed);

		}
		if (timep > 4*difficulty && isdone4 == false) {
			bananaspeed += 1;
			isdone4 = true;
			Debug.Log ("increase in b-speed: " + bananaspeed);
			//potentially play a scary sound?

		}
		//Debug.Log (timep);
}
}
//