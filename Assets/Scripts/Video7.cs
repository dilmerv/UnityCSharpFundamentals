using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video7 : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToMove;

    [SerializeField]
    private Vector3 targetLocation;

    // static classes and when should we use them?
    void Start()
    {
        Movement.Move(objectToMove, targetLocation);
        GameObject objectToFind = GameObject.Find("Video7");

        // make sure we find the video before we call Movement.GetName()
        if(objectToFind != null){
            string videoName = Movement.GetName(objectToFind);
            Debug.Log(videoName);
        }

        Movement movementObject = new Movement(targetLocation.x, targetLocation.y);
    }
}
