using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {
	public int value = 9;

	// Use this for initialization
	void Start() {
		value = Double(value);
		Debug.Log(value);
	}

	private int Double(int inputValue) {
		int result;
    result = inputValue * 2;

    return result;
	}
}