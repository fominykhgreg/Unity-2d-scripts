using UnityEngine;
using System.Collections;

public class PauseEsc : MonoBehaviour {
	private bool paused = false;
	public GameObject panel;

	public static bool pause = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (!paused) {
				Time.timeScale = 0;
				paused = true;
				panel.SetActive (true);
				AudioListener.pause = true;
				
			} else {
				Time.timeScale = 1;
				paused = false;
				panel.SetActive (false);
				AudioListener.pause = false;
		
			}
		}
		
	}
}
