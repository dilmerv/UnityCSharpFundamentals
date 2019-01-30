using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video2 : MonoBehaviour
{
    void Start()
    {
        // logical expressions
        // 1==1 (true)
        // 1==2 (false)
        // 1!=2 (true)
        // 2!=2 (false)
        // "Dilmer" == "Steve"
        // 1.33333 == 1.33333 (true)
        // 1.333334 == 1.33333 (false)

        int numberOne = 1;
        int numberTwo = 2;
        string nameOne = "J";
        string nameTwo = "DV";
        bool isValid = true;

        // if statement where first condition is true
        if (numberOne == 1)
        {
            Debug.Log("Yes the var numberOne == 1 is true");
        }
        else {
            Debug.Log("No the var numberOne == 1 is false");
        }

        // if statement where else is true
        if (numberOne == numberTwo)
        {
            Debug.Log("Yes the var numberOne == 1 is true");
        }
        else
        {
            Debug.Log("No the var numberOne == 1 is false");
        }


        // if statement where else is true
        if (numberOne == numberTwo)
        {
            Debug.Log("Yes the var numberOne == 1 is true");
        }// else if statement where else is true
        else if (numberOne == 1 && isValid)
        {
            Debug.Log("Yes the var numberOne == 1 && isValid");
        }
        else
        {
            Debug.Log("No the var numberOne == 1 is false");
        }
        
        // if statement where else is true
        if (numberOne == numberTwo || isValid)
        {
            Debug.Log("Yes numberOne == numberTwo || isValid");
        }

        isValid = numberOne == numberTwo;
        Debug.Log("IsValid == " + isValid);
        Debug.Log("Check Equality: " + CheckValueEquality(1, 1));
        Debug.Log("Check Equality: " + CheckValueEquality(100, 200));

        // (true && true) 
        // (true && false)
        // (true || false)

        if (nameOne == nameTwo)
        {
            Debug.Log("Yes nameOne == nameTwo");
        }
        else {
            Debug.Log("No nameOne == nameTwo");
        }

        if (nameOne.Length >= 2 && nameTwo.Length >= 3)
        {
            Debug.Log("Yes nameOne.Length >= 2 && nameTwo.Length >= 3");
        }
        else
        {
            Debug.Log("No nameOne.Length >= 2 && nameTwo.Length >= 3");
        }
    }

    bool CheckValueEquality(int value1, int value2)
    {
        return value1 == value2;
    }

}
