using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputControl 
{
    string ControlTypeName
    {
        get;
        set;
    }
    void MoveRight(float distance);
    void MoveLeft(float distance);
    void MoveUp(float distance);
    void MoveDown(float distance);
    float Jump(float force);
}
