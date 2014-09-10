using UnityEngine;
using System.Collections;

public class While : MonoBehaviour {
	public int cup=3;
	void Start() {
		while(cup > 0) {
			Debug.Log ("I've washed a cup!");
			cup--;	
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
