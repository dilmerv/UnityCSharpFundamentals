using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video1 : MonoBehaviour
{
    // int
    // decimal
    // float
    // string
    // object

    int age = 25;
    string fullName = "John Doe";
    decimal weight = 180.5M;
    float position = 1000.0000002f;

    void Start()
    {
        PrintPersonInformation(100);
        Debug.Log("GetPersonAge() " + GetPersonAge());
        Debug.Log("GetFullNameLength() " + GetFullNameLength());
    }

    void PrintPersonInformation()
    {
        var personAge = 3333;
        var personName = "John Doe 2";

        Debug.Log(personAge);
        Debug.Log(personName);

        Debug.Log(age);
        Debug.Log(fullName);
        Debug.Log(weight);
        Debug.Log(position);

        age = 45;
        fullName = "John Toner";

        Debug.Log(age);
        Debug.Log(fullName);
    }

    void PrintPersonInformation(int newAge)
    {
        age = newAge;
        PrintPersonInformation();
    }

    int GetPersonAge()
    {
        return age;
    }

    int GetFullNameLength()
    {
        return fullName.Length;
    }
}
