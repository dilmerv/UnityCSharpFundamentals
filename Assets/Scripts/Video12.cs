using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class Video12 : MonoBehaviour
{
    // TODO
    // 1- Joining strings together by using + symbol
    // 2- String Interpolation
    // 3- Using and Looking into adding the StringBuilder
    // 4- Extend example 1 and improve it with string.format
    void Start()
    {
        // 1- Joining strings together by using + symbol
        string firstName = "John";
        string lastName = "Doe";
        int age = 25;
        string fullName = "1) Full Name: " + firstName + " " + lastName + "| Age: " + age;
        Debug.Log(fullName);

        // 2- String Interpolation
        string newFullName = $"2) Full Name: {firstName} {lastName} | Age: {age}"; 
        Debug.Log(newFullName);

        // 3- Using and Looking into adding the StringBuilder
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("3) Full Name: ");
        stringBuilder.Append(firstName);
        stringBuilder.Append(" ");
        stringBuilder.Append(lastName);
        stringBuilder.Append(" | ");
        stringBuilder.Append("Age: ");
        stringBuilder.Append(age);
        Debug.Log(stringBuilder.ToString());

        // 4- Going back to 1 and improving it with string.format
        Debug.Log(string.Format("4) Full Name: {0} {1} | Age: {2}", firstName, lastName, age));
    }
}
