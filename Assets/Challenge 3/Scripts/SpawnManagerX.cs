using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        // Start invoking the SpawnObjects method repeatedly
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Spawn obstacles
   void SpawnObjects()
{
    Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
    int index = Random.Range(0, objectPrefabs.Length);

    if (!playerControllerScript.gameOver)
    {
        Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
    }
}


    }

