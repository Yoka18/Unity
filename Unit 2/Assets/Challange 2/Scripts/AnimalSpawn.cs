using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    public GameObject[] animals;
    public int spawnRangeX = 9;
    public int spawnRangeZ = 7;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AnimalSpawnerX", Random.Range(0.5f,3f), Random.Range(1.5f,4f));
        InvokeRepeating("AnimalSpawnerZ", Random.Range(0.5f,3f), Random.Range(1f,4f));
        InvokeRepeating("AnimalSpawnerZnegative", Random.Range(0.5f,3f), Random.Range(1f,4f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void AnimalSpawnerX()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosX= new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, 15);
        Instantiate(animals[animalIndex], spawnPosX, Quaternion.Euler(0, 180, 0));
    }

    void AnimalSpawnerZ()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosZ = new Vector3(18, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animals[animalIndex], spawnPosZ, Quaternion.Euler(0, -90, 0));
    }

    void AnimalSpawnerZnegative()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosZneg = new Vector3(-18, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animals[animalIndex], spawnPosZneg, Quaternion.Euler(0,90,0));
    }
}
