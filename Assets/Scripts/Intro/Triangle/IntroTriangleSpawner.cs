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

public class IntroTriangleSpawner : MonoBehaviour
{

    public float SpawnSpeed;
    public GameObject triangle;

    public float SpawnSpeedFinal;
    [SerializeField] UnityEngine.UI.Slider spawnSpeedSlider;
    [SerializeField] UnityEngine.UI.Slider S_YSpeedMin;
    [SerializeField] UnityEngine.UI.Slider S_YSpeedMax;
    [SerializeField] UnityEngine.UI.Slider S_OpacityMin;
    [SerializeField] UnityEngine.UI.Slider S_OpacityMax;
    [SerializeField] UnityEngine.UI.Slider S_ScaleMin;
    [SerializeField] UnityEngine.UI.Slider S_ScaleMax;
    public Text hex;
    public GameObject Savedialog;
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

            GameObject go = Instantiate(triangle, new Vector3(0, 0, 0), Quaternion.identity);
            Triangle tri = go.GetComponent<Triangle>();
            //tri.S_YSpeedMin = S_YSpeedMin;
            //tri.S_YSpeedMax = S_YSpeedMax;
            //tri.S_OpacityMin = S_OpacityMin;
            //tri.S_OpacityMax = S_OpacityMax;
            //tri.S_ScaleMin = S_ScaleMin;
            //tri.S_ScaleMax = S_ScaleMax;
            //tri.Init();
        }
    }
    
    // public void SetVariables(float LoadedSS, float LoadedYSpeedMin, float LoadedYSpeedMax, float LoadedOMin, float LoadedOMax, float LoadedSMin, float LoadedSMax)
    // {
    //     LoadedSS = SpawnSpeed;
    //     LoadedYSpeedMin = tri.YSpeedMin;
    // }
}
