using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Video16 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;
    
    void Start()
    {
        // taxi queue 
        Queue taxiQueue = new Queue();

        // queue a new person
        taxiQueue.Enqueue("John Doe");
        taxiQueue.Enqueue("Jacky Chan");
        taxiQueue.Enqueue("Michael Jordan");
        taxiQueue.Enqueue("Steve Jobs");

        // show information in queue
        showInformationInQueue(taxiQueue);

        // take a taxi
        string personTakingTaxi = taxiQueue.Dequeue().ToString();
        queueDebug.text += $"***Person taking a taxi: {personTakingTaxi}\n\n";

        // show information in queue
        showInformationInQueue(taxiQueue);

        string secondPersonTakingTaxi = taxiQueue.Dequeue().ToString();
        string thirdPersonTakingTaxi = taxiQueue.Dequeue().ToString();
        queueDebug.text += $"***Person taking a taxi: {secondPersonTakingTaxi}\n\n";
        queueDebug.text += $"***Person taking a taxi: {thirdPersonTakingTaxi}\n\n";

        // show information in queue
        showInformationInQueue(taxiQueue);
    }

    void showInformationInQueue(Queue queue)
    {
        queueDebug.text += "-------------------------\n\n";
        foreach (var queueItem in queue)
        {
            queueDebug.text += $"Queue Item -> {queueItem} \n";   
        }
    }
}
