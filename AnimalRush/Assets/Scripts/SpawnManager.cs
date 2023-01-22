using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int xRange = 10;
    private float startDelay = 2f;
    private float spawnInterval = 0.5f;
    public int xSpawn = 20;
    public int zSpawn = 18;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandomAnimal(){
        int index = Random.Range(0,3);
         switch(index) 
        {
            case 0:
                RandomTopAnimal();
                break;
            case 1:
                SpawnLeftAnimal();
                break;
            case 2:
                SpawnRightAnimal();
                break;
            default:
                break;
        }
    }

    void RandomTopAnimal(){
        int animaIndex = Random.Range(0,animalPrefabs.Length);
        int spawnPositionX = Random.Range(-xRange,xRange);
        Instantiate(animalPrefabs[animaIndex], new Vector3(spawnPositionX,0,zSpawn),animalPrefabs[animaIndex].transform.rotation);
    }

    void SpawnLeftAnimal(){
        int animaIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 rotation = new Vector3(0, 90, 0);
        int spawnPositionZ = Random.Range(0,zSpawn);
        Instantiate(animalPrefabs[animaIndex], new Vector3(-xSpawn,0,spawnPositionZ),Quaternion.Euler(rotation));
    }

      void SpawnRightAnimal(){
        int animaIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 rotation = new Vector3(0, -90, 0);
        int spawnPositionZ = Random.Range(0,zSpawn);
        Instantiate(animalPrefabs[animaIndex], new Vector3(xSpawn,0,spawnPositionZ),Quaternion.Euler(rotation));
    }
}
