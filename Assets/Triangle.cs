using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public GameObject TriPrefab;
    public float YSpeedMin;
    public float YSpeedMax;
    public float OpacityMin;
    public float OpacityMax;
    public float ScaleMin;
    public float ScaleMax;
    public float FinalSpeed;
    public float FinalScale;
    public float FinalOpacity;
    public float StartX;
    public float StartY;
    // Sliders
    public UnityEngine.UI.Slider S_YSpeedMin;
    public UnityEngine.UI.Slider S_YSpeedMax;
    public UnityEngine.UI.Slider S_OpacityMin;
    public UnityEngine.UI.Slider S_OpacityMax;
    public UnityEngine.UI.Slider S_ScaleMin;
    public UnityEngine.UI.Slider S_ScaleMax;
    
    public void Init()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(1f, 0f, 0f, 0f, 0f, 1f);
        YSpeedMin  =  S_YSpeedMin.value;
        YSpeedMax  =  S_YSpeedMax.value;
        OpacityMin =  S_OpacityMin.value;
        OpacityMax =  S_OpacityMax.value;
        ScaleMin   =  S_ScaleMin.value;
        ScaleMax   =  S_ScaleMax.value;
        SpriteRenderer spRend = transform.GetComponent<SpriteRenderer>();
        Color col = spRend.color;
        FinalOpacity = Random.Range(OpacityMin, OpacityMax);
        col.a = FinalOpacity;
        spRend.color = col;
        StartX = Random.Range(-10.1f, 10.1f); //Gets X for spawn
        StartY = -8 ; //Sets startY to just off screen
        FinalScale = Random.Range(ScaleMin, ScaleMax); //Sets FinalScale to a random number between ScaleMin and ScaleMax
        FinalSpeed = Random.Range(YSpeedMin, YSpeedMax); //Sets FinalSpeed to a random number between YSpeedMin and YSpeedMax
        transform.position = new Vector3(StartX,StartY,0); //Sets the position to StartX and StartY, sets Z to 0
        transform.localScale = new Vector3(FinalScale, FinalScale, 1); //Sets the scale to FinalScale
        S_YSpeedMin.onValueChanged.AddListener(SET_S_YSMIN);
        S_YSpeedMax.onValueChanged.AddListener(SET_S_YSMAX);
        S_OpacityMin.onValueChanged.AddListener(SET_S_OMIN);
        S_OpacityMax.onValueChanged.AddListener(SET_S_OMAX);
        S_ScaleMin.onValueChanged.AddListener(SET_S_SMIN);
        S_ScaleMax.onValueChanged.AddListener(SET_S_SMAX);
    }
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * FinalSpeed; //Moves up at speed of FinalSpeed
        if (transform.position.y >= 20) { 
            Destroy(gameObject);
        }
    }
    void SET_S_YSMIN(float value)
    {
        
        YSpeedMin = value;
    }
    void SET_S_YSMAX(float value)
    {
        
        YSpeedMax = value;
    }
    void SET_S_OMIN(float value)
    {
        
        OpacityMin = value;
    }
    void SET_S_OMAX(float value)
    {
        
        OpacityMax = value;
    }
    void SET_S_SMIN(float value)
    {
        
        ScaleMin = value;
    }
    void SET_S_SMAX(float value)
    {
        
        ScaleMax = value;
    }
}