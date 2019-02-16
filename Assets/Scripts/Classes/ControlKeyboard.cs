using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlKeyboard : IInputControl
{
    public string ControlTypeName
    {
        get;
        set;
    }
    
    public void MoveRight(float distance)
    {
        Debug.Log($"{ControlTypeName} MoveRight {distance}");
    }

    public void MoveLeft(float distance)
    {
        Debug.Log($"{ControlTypeName} MoveLeft {distance}");
    }

    public void MoveUp(float distance)
    {
        Debug.Log($"{ControlTypeName} MoveUp {distance}");
    }

    public void MoveDown(float distance)
    {
        Debug.Log($"{ControlTypeName} MoveDown {distance}");
    }

    public float Jump(float force)
    {
        Debug.Log($"{ControlTypeName} Jump {force}");
        return force * 3;
    }
}
