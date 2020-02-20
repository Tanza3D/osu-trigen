using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;
using System.IO;

public class setvar : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Slider spawnSpeedSlider;
    [SerializeField] UnityEngine.UI.Slider S_YSpeedMin;
    [SerializeField] UnityEngine.UI.Slider S_YSpeedMax;
    [SerializeField] UnityEngine.UI.Slider S_OpacityMin;
    [SerializeField] UnityEngine.UI.Slider S_OpacityMax;
    [SerializeField] UnityEngine.UI.Slider S_ScaleMin;
    [SerializeField] UnityEngine.UI.Slider S_ScaleMax;
    public Text hex;
    public Text debug;
    public float triamount;
    // Start is called before the first frame update
    void Start()
    {
        trivars.spawnspeed = spawnSpeedSlider.value;
        trivars.speed = S_YSpeedMin.value;
        trivars.opacity = S_OpacityMin.value;
        trivars.smin = S_ScaleMin.value;
        trivars.smax = S_ScaleMax.value;
        trivars.hex = hex.text;

        trivars.orig_spawnspeed = trivars.spawnspeed;
        trivars.orig_speed = trivars.speed;
        trivars.orig_opacity = trivars.opacity;
        trivars.orig_smin = trivars.smin;
        trivars.orig_smax = trivars.smax;
        trivars.orig_hex = trivars.hex;
    }

    // Update is called once per frame
    void Update()
    {
        trivars.spawnspeed = spawnSpeedSlider.value;
        trivars.speed = S_YSpeedMin.value;
        trivars.opacity = S_OpacityMin.value;
        trivars.smin = S_ScaleMin.value;
        trivars.smax = S_ScaleMax.value;
        trivars.hex = hex.text;

        trivars.hex = trivars.hex.Replace("#", "");

        triamount = GameObject.FindGameObjectsWithTag("Triangle").Length;

        debug.text = 
            "Spawnspeed: " + trivars.spawnspeed.ToString()
            + "\nSpeed: " + trivars.speed.ToString()
            + "\nOpacity: " + trivars.opacity.ToString()
            + "\nSizeMin: " + trivars.smin.ToString()
            + "\nSizeMax: " + trivars.smax.ToString()
            + "\nO_Spawnspeed: " + trivars.orig_spawnspeed.ToString()
            + "\nO_Speed: " + trivars.orig_speed.ToString()
            + "\nO_Opacity: " + trivars.orig_opacity.ToString()
            + "\nO_SizeMin: " + trivars.orig_smin.ToString()
            + "\nO_SizeMax: " + trivars.orig_smax.ToString()
            + "\nHex: " + trivars.hex
            + "\nTriAmount: " + triamount
            ;
    }
}
