using UnityEngine;
using System.Collections;

public class test_clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		/**
		 * method 1
		 * using Broadcast method call the destroy function in the script that we have attached to the children
		 * 
		 * CODE
		 * - Broadcast("ToDestroy");
		 * 
		 * method 2
		 * find all children and then destroy them
		 * 
		 * CODE
		 * - Transform[] children = GetComponentsInChildrens<Transform>();
		 * - for(int i = 0;i < children.length;i++)//foreach....
		 * -	Destroy(children[i];
		 * 
		**/




	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
