using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menufunctions : MonoBehaviour {

	// Use this for initialization
	public void startgame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	}

	public void quitgame(){
		Application.Quit();

	}
}
