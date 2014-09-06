using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

    float coffeeTemperature = 85.0f;
    float hotLimit = 70.0f;
    float coldLimit = 40.0f;
    
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
        }
    }
    
    void TemperatureTest() {
        if(coffeeTemperature > hotLimit) {
            print("Too hot");
        } else if(coffeeTemperature < oldLimit) {
            print("Too cold");
        } else {
            print("Coffee is just right");
        }
    }
}
