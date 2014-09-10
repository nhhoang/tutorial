using UnityEngine;
using System.Collections;

public class For : MonoBehaviour {
	public enemy = 5;
	void Start() {
	for (i=0; i<enemy; i++) {
			Debug.Log("Creat enemy: " + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
