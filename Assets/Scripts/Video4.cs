using UnityEngine;

public class Video4 : MonoBehaviour
{
    void Start()
    {
        // Creating a Human
        Debug.Log("Creating a human");
        // className variableName = new className();
        Human human1 = new Human("John", "Doe", 15);

        // Testing Properties
        Debug.Log(human1.FirstName);
        Debug.Log(human1.LastName);
        Debug.Log(human1.FullName);
        
        // Testing Methods
        Debug.Log("Is this human valid? " + human1.IsValid());
        Debug.Log("Is this human an adult? " + human1.IsAnAdult());
        Debug.Log("What is the length in characters of the full name? " + human1.FullNameSize());

        // Creating a Player
        Debug.Log("Creating a player");
        Player player1 = new Player("Steve", "Toner", 25, "steveToner@xbox.com");

        // Testing Properties
        Debug.Log(player1.FirstName);
        Debug.Log(player1.LastName);
        Debug.Log(player1.FullName);
        Debug.Log(player1.XboxOneLiveID);

        // Player killed monster
        // Add 100 points to the score
        player1.IncrementScore(100);
        Debug.Log("New Player Score is: " + player1.GetScore().Points);
        player1.IncrementScore(100);
        player1.IncrementScore(100);
        player1.IncrementScore(100);
        Debug.Log("New Player Score is: " + player1.GetScore().Points);

        // Create a monster
        Monster monster = new Monster();
        Debug.Log("Monster information: " + monster);

        // Polymorphism examples
        Human fromMonsterToHuman = (Human)monster;
        Debug.Log("Human information from Monster: " + fromMonsterToHuman);

        Human fromPlayerToHuman = (Human)player1;
        Debug.Log("Human information from Player: " + fromPlayerToHuman);

        // From a human to a player
        Player fromAHumanToAPlayer = new Player(human1.FirstName, human1.LastName, human1.Age,
            human1.FirstName +
            human1.LastName + "@xbox.com");

        Debug.Log("Player information from Human: " + fromAHumanToAPlayer);
    }
}
