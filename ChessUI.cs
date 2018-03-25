using UnityEngine;
using System.Collections;

public class ChessUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Box (new Rect (10, 10, 100, 90), "Menu");
		if (GUI.Button (new Rect (20, 40, 80, 20), "NewGame")) {
			NewGame ();
		}
	}

	void NewGame(){
		BroadcastMessage ("Restart");
	}
}
