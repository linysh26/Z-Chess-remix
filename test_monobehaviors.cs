using UnityEngine;
using System.Collections;

//attach it to an empty object

public class test_monobehaviors : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		Debug.Log ("Awake");
	}

	void Start () {
		Debug.Log ("Start");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update");
	}

	void FixedUpdate(){
		Debug.Log ("FixedUpdate");
	}

	void LateUpdate(){
		Debug.Log ("LateUpdate");
	}

	//attach to a cube or something else, anyway
	void OnGUI(){
		Debug.Log ("OnGUI");
		if (GUI.Button (new Rect (10, 10, 80, 20), "I'm labelty!"))
			GUI.Label (new Rect (Screen.width - 50, Screen.height - 20, 100, 40), "(ノ｀Д)ノ┻━┻");
	}

	void OnDisabled(){
		Debug.Log ("...");
	}

	void OnEnabled(){
		Debug.Log ("2333333");
	}
}
