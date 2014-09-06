using UnityEngine;
using System.Collections;

public class CSharpSyntax : MonoBehaviour {
	public int value = 5;

	public int MyFunction(int InputNumber) {
    int result = value * InputNumber;
    return result;
  }
}
