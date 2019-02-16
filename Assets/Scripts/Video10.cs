using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video10 : MonoBehaviour
{

    private string _someField = "Some Field";

    public string SomeProperty
    {
        get 
        {
            return _someField;
        }
        set 
        {
            _someField = value;
        }
    }

    public string SomeCoolerProperty { get => _someField; set => _someField = value; }

    void DebugSomething() => Debug.Log("GameObject Location: " + gameObject.transform.position);

    string GetSomeData () => SomeProperty;

    bool IsThisObjectValid () => SomeProperty.Length >= 3;

    string GetSomeDataWithReturn()
    {
        return SomeProperty;
    }

    void Start()
    {
        DebugSomething();

        Debug.Log("SomeProperty: " + SomeProperty);
        Debug.Log("SomeCoolerProperty: " + SomeCoolerProperty);

        SomeProperty = "SomeProperty Changed";

        Debug.Log("SomeProperty: " + SomeProperty);
        Debug.Log("SomeCoolerProperty: " + SomeCoolerProperty);

        SomeCoolerProperty = "SomeCoolerProperty Changed";

        Debug.Log("SomeProperty: " + SomeProperty);
        Debug.Log("SomeCoolerProperty: " + SomeCoolerProperty);
    }

    
}
