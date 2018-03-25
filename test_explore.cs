using UnityEngine;
using System.Collections;

public class test_explore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Traverse (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Traverse(GameObject parent){
		Transform[] children = parent.GetComponentsInChildren<Transform> ();

		foreach (Transform child in children) {
			Traverse (child.gameObject);
		}

	}
}