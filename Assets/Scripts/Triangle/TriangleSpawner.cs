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

public class TriangleSpawner : MonoBehaviour
{

    public float SpawnSpeed;
    public GameObject triangle;
    public float SpawnSpeedFinal;
    public Text hex;
    public GameObject Savedialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnSpeed = trivars.spawnspeed;
        SpawnSpeedFinal = Random.Range(0, SpawnSpeed);
        if (SpawnSpeedFinal > 5)
        {

            GameObject go = Instantiate(triangle, new Vector3(0, 0, 0), Quaternion.identity);
            Triangle tri = go.GetComponent<Triangle>();
            tri.Init();
        }

        osumodecontroller.hex = hex.GetComponent<Text>().text;
        osumodecontroller.hex = osumodecontroller.hex.Replace("#", "");
        //Removed Hex Length Fallback (Issue Fixed)
        Debug.Log(osumodecontroller.hex);
    }

   // public void SetVariables(float LoadedSS, float LoadedYSpeedMin, float LoadedYSpeedMax, float LoadedOMin, float LoadedOMax, float LoadedSMin, float LoadedSMax)
   // {
   //     LoadedSS = SpawnSpeed;
   //     LoadedYSpeedMin = tri.YSpeedMin;
   // }
}
