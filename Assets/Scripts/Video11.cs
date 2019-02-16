using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video11 : MonoBehaviour
{
    private IInputControl keyboardControl = null;
    private IInputControl touchControl = null;
    List<IInputControl> supportedInputControls = new List<IInputControl>();

    void Awake()
    {
        keyboardControl = new ControlKeyboard();
        keyboardControl.ControlTypeName = "Keyboard";

        touchControl = new ControlTouch();
        touchControl.ControlTypeName = "Touch";

        // added keyboard control
        supportedInputControls.Add(keyboardControl);

        // added touch control
        supportedInputControls.Add(touchControl);

        foreach (IInputControl supportedControl in supportedInputControls)
        {
            Debug.Log($"Looping through supportedControl -> {supportedControl.ControlTypeName}");
            supportedControl.MoveRight(100);
            supportedControl.MoveLeft(100);
            supportedControl.Jump(100);

            if(supportedControl is ControlKeyboard)
            {
                Debug.Log("This implements ControlKeyboard");
            }
            else if(supportedControl is ControlTouch)
            {
                Debug.Log("This implements ControlTouch");
            }
        }

    }
    void Start()
    {
        Debug.Log("Start examples for video11");

        // few input actions for the keyboard
        keyboardControl.MoveRight(100);
        keyboardControl.MoveLeft(1000);
        float jumpValueForKeyboard = keyboardControl.Jump(1000);

        // few input actions for the touch
        touchControl.MoveLeft(200);
        touchControl.MoveUp(2000);
        touchControl.MoveRight(2000);
        float jumpValueForTouch = touchControl.Jump(500);
    }
}
