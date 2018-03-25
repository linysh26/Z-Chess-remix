using UnityEngine;
using System.Collections;

public class test_find : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// we can find object by its name.
		GameObject.Find("name");
		//or we can find object by its tag, which is generally efficient, for we don't need to traverse all the game object in the scene.
		//notice that you should have set the tag of the object you want to find.
		GameObject.FindWithTag("Tag");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
