using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video3 : MonoBehaviour
{
    // loops
    void Start()
    {
        // for loop
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log("1st For Loop : " + i);
        }

        // for loop in reverse
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log("2nd For Loop : " + i);
        }

        // 1st while loop
        int max = 10;
        int incrementer = 0;
        while (true)
        {
            if(incrementer == max)
            {
                Debug.Log("1st While loop - I hit the max");
                incrementer = 0;
                break;
            }
            incrementer++;
        }

        // 2nd while loop
        while (incrementer <= max)
        {
            if (incrementer == max)
            {
                Debug.Log("2nd While loop - I hit the max");
            }
            incrementer++;
        }

        // for loop with ages array
        int[] ages = new int[] { 5, 20, 33, 12, 15, 16, 17, 80, 90, 10 };
        
        for (int i = 0; i < ages.Length; i++)
        {
            Debug.Log("Age: index-> " + i + " value-> " + ages[i]);
        }
        
        string[] peopleNames = new string[] { "John", "Steve", "Andres", "Joe" };

        foreach (string name in peopleNames)
        {
            Debug.Log(name);
        }

        Debug.Log("Ending Loops");
    }

}
