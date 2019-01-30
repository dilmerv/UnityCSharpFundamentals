using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Human
{
    private string xboxOneLiveID;
    private Score score = new Score();
    
    public string XboxOneLiveID
    {
        get
        {
            return xboxOneLiveID;
        }
    }
    
    public Player(string firstName, string lastName, int age, string xboxOneLiveID) : base(firstName, lastName, age)
    {
        this.xboxOneLiveID = xboxOneLiveID;
    }

    public void SetXboxOneLiveID(string newId)
    {
        this.xboxOneLiveID = newId;
    }

    public Score GetScore()
    {
        return score;
    }

    public void IncrementScore(decimal newScore)
    {
        score.Points += newScore;
    }
}
