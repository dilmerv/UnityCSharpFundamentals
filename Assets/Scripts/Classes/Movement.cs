using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    private float theX, theY;

    public Movement(float x, float y)
    {
        this.theX = x;
        this.theY = y;

        Debug.Log("X =" + this.theX);
        Debug.Log("Y =" + this.theY);
    }

    // Movement movementVariable = new Movement(); (THIS IS INVALID)
    // Movement.(Method);
    // Movement.Move(new Vector3(10,10,10));
    // Movement.GetName(GameObject.Find("Video6"));
    public static void Move(GameObject gameObject, Vector3 target)
    {
        gameObject.transform.position = target;
    }

    public static string GetName(GameObject gameObject)
    {
        return gameObject.name;
    }
}
