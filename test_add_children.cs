using UnityEngine;
using System.Collections;

public class test_add_children : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//first, we instantiate a game object
		GameObject newObject = Instantiate (Resources.Load ("Chess_1")) as GameObject;
		//set this script's game object as its parent, then we successfully add a child to this game object.
		newObject.transform.parent = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
