using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video9 : MonoBehaviour
{
    void Start()
    {
        Fruit fruit = new Fruit("Apple", new Vector3(20,30,40), 5.0f);

        Debug.Log(fruit.GetName());

        Debug.Log(fruit.Name);

        // update fruit to apple
        // fruit.Name = "Apple"; (THIS IS PRIVATE AND INNACESSIBLE)
        Debug.Log("This fruit is becoming an : " + fruit.Name);

        fruit.SetName("Banana");
        Debug.Log("This fruit is becoming a : " + fruit.Name);

        // printing out x y z
        Debug.Log("LocationAtX: " + fruit.LocationAtX);
        Debug.Log("LocationAtY: " + fruit.LocationAtY);
        Debug.Log("LocationAtZ: " + fruit.LocationAtZ);

        Debug.Log("Location Vector3: " + fruit.Location);
        Debug.Log("Location Vector3-X: " + fruit.Location.x);

        Fruit fruitTestingLocation = new Fruit("fruitTestingLocation", new Vector3(1,1,1), 5.0f);
        Debug.Log("fruitTestingLocation.IsLocationSet: " + fruitTestingLocation.IsLocationSet);
    }
}
