using UnityEngine;
using System.Collections;

public class ConventionsandSyntax : MonoBehaviour {

	void Start() {
		Debug.Log(transform.position.x);
		if(transform.position.y <= 5f) {
			Debug.Log ("Fall");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
