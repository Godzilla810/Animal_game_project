using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 15;
    private float spawnPosX = 25;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFrontAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay+1, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay+2, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnFrontAnimal(){
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAnimal(){
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(5,spawnRangeZ));
        Vector3 rotation = new Vector3(0,-90,0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal(){
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(5,spawnRangeZ));
        Vector3 rotation = new Vector3(0,90,0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

}
