using UnityEngine;
using System.Collections;

public class gridAction : MonoBehaviour {

	Material original;
	// Use this for initialization
	void Start () {
		original = GetComponent<Renderer>().material;
	}

	void OnMouseEnter(){
		GetComponent<Renderer> ().material = new Material(Shader.Find("Diffuse"));
	}

	void OnMouseExit(){
		GetComponent<Renderer> ().material = original;
	}

	void OnMouseUp(){
		SendMessageUpwards ("Register", this.gameObject.name);
	}
}
