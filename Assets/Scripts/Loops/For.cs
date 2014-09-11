using UnityEngine;
using System.Collections;

public class For : MonoBehaviour {
	public enemy = 3;
	void Start() {
	for (int i = 0; i<enemy; i++) {
			Debug.Log("Creat enemy: " + i);
		}
	}
	
	void Update () {
	
	}
}
