using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {
	int a = 9;

	// Use this for initialization
	void Start () {
		a = NhanDoi(a) ;
		Debug.Log (a) ;
	}

	int NhanDoi (int So)
	{
		int kq ;
    kq = So * 2;
    return kq;
	}

	
	
}
