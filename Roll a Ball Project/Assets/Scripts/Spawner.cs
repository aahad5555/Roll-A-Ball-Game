using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PickUp;
    public Vector3 SpawnAxis;
    public Vector3 location;

    
   // public Collider[] colliders;
    //public float radius;

    // Start is called before the first frame update
    void Start()
    {
        int spawnedLocation = 0;
        while (spawnedLocation <= 9)
        {
            

           
            location = new Vector3(Random.Range(-SpawnAxis.x, SpawnAxis.x), SpawnAxis.y, Random.Range(-SpawnAxis.z, SpawnAxis.z));
            Instantiate(PickUp, location, Quaternion.identity);
            spawnedLocation++;

               
            
        }
    }
}
