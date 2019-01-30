using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Video6 : MonoBehaviour
{
    // Learn how to declare and use collections...

    // Start Arrays

    // List

    // IEnumerables

    // Dictionary
    
    void Start()
    {
        // 5 Bananas

        // String Arrays

        // Arrays are 0 index
        string[] bananas = new string[5];
        bananas[0] = "banana_1";
        bananas[1] = "banana_2";
        bananas[2] = "banana_3";
        bananas[3] = "banana_4";
        bananas[4] = "banana_5";

        PrintValues("Printing String[]: Bananas -> ", bananas);

        int[] ages = new int[2];
        ages[0] = 25;
        ages[1] = 35;

        PrintValues("Printing int[]: Ages -> ", ages);

        decimal[] amounts = new decimal[3];
        amounts[0] = 400.45M;
        amounts[1] = 800.45M;
        amounts[2] = amounts[1] * 2;

        PrintValues("Printing decimal[]: Amounts -> ", amounts);

        string[] names = new string[] { "John Doe", "Steve Toner", "Bruny Toner" };

        PrintValues("Printing string[]: names -> ", names);

        Debug.Log("Printing the size of the names array: " + names.Length);

        // Lists
        List<string> namesWithList = new List<string>();
        namesWithList.Add("John Doe");
        namesWithList.Add("Steve Toner");
        namesWithList.Add("Bruny Toner");
        namesWithList.Remove("John Doe");

        PrintValues("Printing List<string>: namesWithList -> ", namesWithList);

        List<int> agesWithList = new List<int>();
        agesWithList.Add(25);
        agesWithList.Add(35);

        PrintValues("Printing List<int>: namesWithList -> ", agesWithList);

        //IEnumerables
        IEnumerable<string> namesWithIEnumerable = Names();
        List<string> getMeTheNames = namesWithIEnumerable.ToList();
        IEnumerable<Human> humans = Humans().ToList();

        //Dictionary

        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict["999-999-8888"] = "5322 W 3430 South, US";
        dict["999-999-8889"] = "1322 W 3430 South, US";
        dict["999-999-8899"] = "2322 W 3430 South, US";

        Dictionary<string, Player> dictionaryOfPlayers = new Dictionary<string, Player>();
        dictionaryOfPlayers["johndoe@xboxlive.com"] = new Player("John", "Doe", 25, "johndoe@xboxlive.com");
        dictionaryOfPlayers["johndoa@xboxlive.com"] = new Player("John", "Doa", 35, "johndoa@xboxlive.com");
        dictionaryOfPlayers["johndob@xboxlive.com"] = new Player("John", "Dob", 45, "johndob@xboxlive.com");
    }

    private IEnumerable<Human> Humans()
    {
        yield return new Human("John", "Doe", 25);
        yield return new Human("John", "Doa", 35);
        yield return new Human("John", "Doi", 45);
        yield return new Human("John", "Dou", 55);
    }

    private IEnumerable<string> Names()
    {
        yield return "John Doe";
        yield return "Steve Toner";
        yield return "Michael Jordan";
    }

    private void PrintValues(string information, IEnumerable items)
    {
        foreach (var item in items)
        {
            Debug.Log(information + item);
        }
    }
}
