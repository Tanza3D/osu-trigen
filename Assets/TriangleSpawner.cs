using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawner : MonoBehaviour
{

    public float SpawnSpeed;
    public GameObject triangle;
    public float SpawnSpeedFinal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnSpeedFinal = Random.Range(0, SpawnSpeed);
        if (SpawnSpeedFinal > 5)
        {
            print("owo");
            Instantiate(triangle, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
