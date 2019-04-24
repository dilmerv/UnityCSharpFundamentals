using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video14 : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectPrefab;
    
    [SerializeField]
    private bool destroyEnemyOnLoad = false;

    void Start()
    {
        // 1- GameObject.Find - Searching for GameObjects in our scene
        GameObject item1GameObject = GameObject.Find("Item1");
        // 2- GameObject.FindGameObjectsWithTag - Searching objects with a specific tag
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in items)
        {
            Debug.Log(item.name);
        }
        // 3- GameObject.FindObjectOfType - Searching objects of type
        Video1 video1 = GameObject.FindObjectOfType<Video1>();
        GameObject video1GameObject = video1.gameObject;
        Debug.Log(video1GameObject.name);

        // 4- GameObject.CreatePrimitive Create primitives (cube)
        GameObject cubeGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // 5- GameObject.CreatePrimitive Create primitives (capsule)
        GameObject capsuleGameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsuleGameObject.transform.transform.localScale = new Vector3(2,2,2);
        capsuleGameObject.transform.transform.localPosition = new Vector3(2,2,2);

        // 6- GameObject.Instantiate to create a 3D model based on a prefab
        GameObject enemyPrefab = Instantiate(gameObjectPrefab, new Vector3(4,4,4), Quaternion.identity);
        
        // 7- GameObject.Destroy destroying a game object
        if(destroyEnemyOnLoad)
            Destroy(enemyPrefab);
    }
}
