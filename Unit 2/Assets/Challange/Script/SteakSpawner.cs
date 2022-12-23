using UnityEngine;

public class SteakSpawner : MonoBehaviour
{
    public GameObject Spawner;
    public float RangeZ = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnManager", 3, Random.Range(0.5f, 2)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnManager()
    {
        Debug.Log("Steak Spawned");
        Vector3 spawnPos = new Vector3(0,20, Random.Range(-2,RangeZ));
        Instantiate(Spawner, spawnPos, Spawner.transform.rotation);
    }
}
