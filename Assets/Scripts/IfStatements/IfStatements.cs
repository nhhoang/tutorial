using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
  public float coffeeTemperature = 85.0f;
  public float hotLimit = 70.0f;
  public float coldLimit = 40.0f;
    
  void Update() {
    if(Input.GetKeyDown(KeyCode.Space)) {
      TemperatureTest();
    }
    coffeeTemperature -= Time.deltaTime * 5f;
  }
    
  void TemperatureTest() {
    if(coffeeTemperature > hotLimit) {
      print("Too hot");
    } else if(coffeeTemperature < coldLimit) {
      print("Too cold");
    } else {
      print("Coffee is just right");
    }
  }
}
