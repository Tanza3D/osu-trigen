using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;
using SFB;
using System.IO;

// this script simply spawns the triangles, the triangles set their own colour and move themselves.

public class TriangleSpawner : MonoBehaviour
{

    public float SpawnSpeed;
    public GameObject triangle;
    public float SpawnSpeedFinal;
    public Text hex;
    public GameObject Savedialog;

    // Update is called once per frame
    void Update()
    {
        SpawnSpeed = trivars.spawnspeed; // gets spawnspeed from slider 
        SpawnSpeedFinal = Random.Range(0, SpawnSpeed); // grabs a random range from 0 to the spawnspeed
        if (SpawnSpeedFinal > 5 && trivars.tripaused == false) // as long as the grabbed range is above 5, and the triangles aren't paused...
        {
            // spawn a triangle
            GameObject go = Instantiate(triangle, new Vector3(0, 0, 0), Quaternion.identity);
            Triangle tri = go.GetComponent<Triangle>();
            tri.Init(); // initiate triangle
        }

        osumodecontroller.hex = hex.GetComponent<Text>().text; // grab text
        osumodecontroller.hex = osumodecontroller.hex.Replace("#", ""); // remove the #
        Debug.Log(osumodecontroller.hex); // log it, no clue why we do this lol
    }
}
