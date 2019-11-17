using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    // Set the variables!

    public GameObject TriPrefab;
    public GameObject Savedialog;
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
    public float FinalZ;
    // Sliders
    public UnityEngine.UI.Slider S_YSpeedMin;
    public UnityEngine.UI.Slider S_YSpeedMax;
    public UnityEngine.UI.Slider S_OpacityMin;
    public UnityEngine.UI.Slider S_OpacityMax;
    public UnityEngine.UI.Slider S_ScaleMin;
    public UnityEngine.UI.Slider S_ScaleMax;
    
    public void Init()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(1f, 0f, 0f, 0f, 0f, 1f); // Sets the triangles to random black or white, or anywhere inbetween colours.
        YSpeedMin  =  S_YSpeedMin.value;  //more slider stuff
        YSpeedMax  =  S_YSpeedMax.value;  //more slider stuff
        OpacityMin =  S_OpacityMin.value; //more slider stuff
        OpacityMax =  S_OpacityMax.value; //more slider stuff
        ScaleMin   =  S_ScaleMin.value;   //more slider stuff
        ScaleMax   =  S_ScaleMax.value;   //more slider stuff
        SpriteRenderer spRend = transform.GetComponent<SpriteRenderer>(); //Sets the spriterendererr spRend to the SpriteRenderer component.
        Color col = spRend.color; //Sets the colour "col" to spRend.color which we set just abov ethis
        FinalOpacity = OpacityMin; // Sets FinalOpacity to the minimum opacity.
        col.a = FinalOpacity; // Sets col.a (colour alpha) to the FinalOpacity 
        spRend.color = col; // Sets spRend colour to col, while your at it why not paint yourself invisible
        StartX = Random.Range(-14.1f, 14.1f); //Gets X for spawn
        StartY = -8 ; //Sets startY to just off screen
        FinalScale = Random.Range(ScaleMin, ScaleMax); //Sets FinalScale to a random number between ScaleMin and ScaleMax
        FinalSpeed = Random.Range(YSpeedMin, YSpeedMax); //Sets FinalSpeed to a random number between YSpeedMin and YSpeedMax
        FinalZ = FinalScale; //Sets FinalZ to Scale, so the smaller the triangles are the closer they are to the camera, closer = smaller number
        transform.position = new Vector3(StartX,StartY,FinalZ); //Sets the position to StartX and StartY, sets Z to 0
        transform.localScale = new Vector3(FinalScale, FinalScale, 1); //Sets the scale to FinalScale
        FinalSpeed = YSpeedMin; //YSpeedMin is connected to the slider in UI called "Triangle Speed". Variable YSpeedMax is unused but kept around for purposes of me being lazy.
        FinalSpeed = FinalSpeed - FinalScale - (FinalScale / 1.5f); //Make it so the smaller the triangles are the faster they move by removing the size from the speed.
        if(FinalSpeed < 0.2f)
        {
            FinalSpeed = 0.2f;
        }
        // Examples
        //
        // If a triangle was the size of two, and the speed was set to 8, the speed would end out as 4.
        // Meanwhile if another triangle was set to the size of 0.2, same speed, it'd end out as 7.6
       
        S_YSpeedMin.onValueChanged.AddListener(SET_S_YSMIN); // adds listeners
        S_YSpeedMax.onValueChanged.AddListener(SET_S_YSMAX); // adds listeners
        S_OpacityMin.onValueChanged.AddListener(SET_S_OMIN); // adds listeners
        S_OpacityMax.onValueChanged.AddListener(SET_S_OMAX); // adds listeners
        S_ScaleMin.onValueChanged.AddListener(SET_S_SMIN);   // adds listeners
        S_ScaleMax.onValueChanged.AddListener(SET_S_SMAX);   // adds listeners
    }
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * FinalSpeed; //Moves up at speed of FinalSpeed
        if (transform.position.y >= 20) { 
            Destroy(gameObject); //Destroys the gameobject if it gets too high to stop lag
        }
    }

    // all of this stuff just sets the variables to the slider variables

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