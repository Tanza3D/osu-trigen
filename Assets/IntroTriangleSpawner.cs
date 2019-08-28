using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTriangleSpawner : MonoBehaviour
{

    public float SpawnSpeed;
    public GameObject triangle;
    public float SpawnSpeedFinal;
    private double trispawnerwaittime;
    // Start is called before the first frame update
    void Start()
    {
        trispawnerwaittime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        trispawnerwaittime += 1;
        SpawnSpeedFinal = Random.Range(0, SpawnSpeed);
        if (trispawnerwaittime >= 100)
        {
            if (SpawnSpeedFinal > 5)
            {
                GameObject go = Instantiate(triangle, new Vector3(0, 0, 0), Quaternion.identity);
                Triangle tri = go.GetComponent<Triangle>();
            }
        }
    }
}
