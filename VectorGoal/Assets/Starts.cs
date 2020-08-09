using UnityEngine;
using System.Collections;

public class Starts : MonoBehaviour {
	public bool running;
	public GameObject butt;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	
	}
	public void Run(){
		running = true;
		butt.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (running) {
			if (Time.timeScale == 0) {
				Time.timeScale = 1;
			}
		}
	
	}
}
