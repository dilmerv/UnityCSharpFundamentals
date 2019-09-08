using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Video15 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;

    void Start()
    {
        // define your stack
        Stack stack = new Stack();

        // prep our data
        int firstPlayerAge = 25;
        int secondPlayerAge = 10;
        int thirdPlayerAge = 30;

        // push a new player age into the stack
        stack.Push(firstPlayerAge);
        stack.Push(secondPlayerAge);
        stack.Push(thirdPlayerAge);

        // show information
        showInformationInStack(stack);

        // pop player age out of the stack
        stack.Pop();

        // show information
        showInformationInStack(stack);

        // pop player age out of the stack
        stack.Pop();

        // show information
        showInformationInStack(stack);

        // pop player age out of the stack
        stack.Pop();

        // show information
        showInformationInStack(stack);
    }

    void showInformationInStack(Stack stack)
    {
        stackDebug.text += "-------------------------\n\n";
        foreach (var stackItem in stack)
        {
            stackDebug.text += $"Stack Item -> {stackItem} \n";   
        }
    }
}
