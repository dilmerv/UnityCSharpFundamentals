using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Video5 : MonoBehaviour
{

    private string fullName = "John Doe";

    void Start()
    {
        // delegate examples
        // defining delegates and executing them
        del sumValuesDelegate = sumValues;

        Debug.Log("sumValuesDelegate(10, 20) " + sumValuesDelegate(10, 20));
        Debug.Log("sumValuesDelegate(100, 200) " + sumValuesDelegate(100, 200));
        Debug.Log("sumValuesDelegate(100, -90) " + sumValuesDelegate(100, -90));

        del substractValuesDelegate = substractValues;

        Debug.Log("substractValuesDelegate(20, 10) " + substractValuesDelegate(20, 10));
        Debug.Log("substractValuesDelegate(200, 150) " + substractValuesDelegate(200, 150));

        // call back examples
        messagesDel messages = displayMessages;
        FindGameObject("Video5", displayMessages);

        // lambda examples

        // Lambda expressions are not limited to LINQ queries. 
        // You can use them anywhere a delegate value is expected, that is, 
        // wherever an anonymous method can be used.
        messagesDel messagesWithLambda = (x) =>
        {
            x = x + " " + " in hierarchy...";
            Debug.Log(x);
        };

        FindGameObject("Video5", messagesWithLambda);
        Debug.Log("FindGameObjectWithLambda(Video5) : " + FindGameObjectWithLambda("Video5"));
        Debug.Log("Property FullName: " + FullName);

        // linq examples and lambdas
        List<Player> players = new List<Player>
        {
            new Player("John","Doe",20,"johndoe@xbox.com"),
            new Player("Bruny","Toner",20,"bruny@xbox.com"),
            new Player("Steve","Doe",30,"stevedoe@xbox.com"),
            new Player("Jason","Doe",40,"jasondoe@xbox.com"),
            new Player("Luis","Toner",50,"luis@xbox.com"),
            new Player("Henry","Doe",60,"henry@xbox.com"),
        };

        // linq
        List<Player> playersWithTheAgeOfTwenty = players.Where(p => p.Age == 20).ToList();
        int playersWithTheAgeOfTwentyCount = players.Count(p => p.Age == 20);
        Debug.Log("playersWithTheAgeOfTwentyCount: " + playersWithTheAgeOfTwentyCount);

        Player playerWithAgeOfTwenty = players.FirstOrDefault(p => p.Age == 20);
        Debug.Log("playerWithAgeOfTwenty: " + playerWithAgeOfTwenty.FirstName);

        Player playerWithAgeOfTwentyLast = players.LastOrDefault(p => p.Age == 20);
        Debug.Log("playerWithAgeOfTwenty: " + playerWithAgeOfTwentyLast.FirstName);
    }

    public string FullName { get => fullName; set => fullName = value; }

    private string FindGameObjectWithLambda(string name) => GameObject.Find(name).name;

    private void FindGameObject(string name, messagesDel callback)
    {
        var foundGameObject = GameObject.Find(name);
        if (foundGameObject == null)
        {
            callback("Unable to find game object with name: " + name);
        }
        else {
            callback("Found game object with name: " + name);
        }
    }

    delegate int del(int x, int y);

    delegate void messagesDel(string messages);

    private void displayMessages(string messages)
    {
        Debug.Log(messages);
    }

    private int sumValues(int x, int y)
    {
        return x + y;
    }

    private int substractValues(int x, int y)
    {
        return x - y;
    }
}
