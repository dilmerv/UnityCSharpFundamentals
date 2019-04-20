using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video13 : MonoBehaviour
{
    private string firstName;
    private string lastName = "";
    private decimal? weight; // Nullable<T>
    private int? age, newAge;
    private float? distance;

    void Start()
    {
        Debug.Log("First Name:");
        Debug.Log(firstName);
        Debug.Log("----------------------------");

        Debug.Log("Last Name:");
        Debug.Log(lastName);
        Debug.Log("----------------------------");

        Debug.Log("Weight:");
        Debug.Log(weight);
        Debug.Log("----------------------------");

        // Age examples

        Debug.Log("Age:");
        Debug.Log(age);

        int newFinalAge = age ?? newAge ?? 18;

        Debug.Log("New Age:");

        Debug.Log(newFinalAge);

        Debug.Log("----------------------------");

        // Distance examples

        if(distance.HasValue)
        {
            Debug.Log("Distance has a value");
        }
        else {
            Debug.Log("Distance doesn't a value");
        }

        distance = distance.GetValueOrDefault(-1);
        Debug.Log("Distance new default value is: " +  distance);
        if (distance == null)
        {
            distance = 500;
        }

        Debug.Log("Distance:");
        Debug.Log(distance);
        Debug.Log("----------------------------");

        // Conditional nullables

        Player player = new Player("John", "Doe", 30, "johndoe@xboxoneline.com");

        Multiplayer multiplayerRoom = 
            player.FirstRoom ?? player.SecondRoom;

        string ipAddressOfSecondHost = 
            multiplayerRoom.SecondaryHost?.IpAdress 
            ?? multiplayerRoom.PrimaryHost?.IpAdress;

        Debug.Log(multiplayerRoom.PrimaryHost.Name);
        Debug.Log(multiplayerRoom.PrimaryHost.IpAdress);
        Debug.Log(multiplayerRoom.MinutesPlayed);
        Debug.Log(multiplayerRoom.DistancePlayed);
    
        

        Debug.Log("ipAddressOfSecondHost");
        Debug.Log(ipAddressOfSecondHost);

    }
}
