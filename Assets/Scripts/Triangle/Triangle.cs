using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    // Set the variables!

    AudioSource m_MyAudioSource;
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
    public Sprite hitcircle;
    public Sprite trianglespr;
    public Text hexcode;
    // Sliders
    public UnityEngine.UI.Slider S_YSpeedMin;
    public UnityEngine.UI.Slider S_YSpeedMax;
    public UnityEngine.UI.Slider S_OpacityMin;
    public UnityEngine.UI.Slider S_OpacityMax;
    public UnityEngine.UI.Slider S_ScaleMin;
    public UnityEngine.UI.Slider S_ScaleMax;
    public float randomadd;
    public float wait;
    public float waitamount;
    public float colors;
    public string hextext;
    public float clicked;

    public string hexcodetext;
    Collider m_Collider;

    // ET TRIGEN TRIANGLE V3

    public static byte[] ConvertHexStringToByteArray(string hexString)
    {
        if (hexString.Length % 2 != 0)
        {
            throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
        } // detects if the hex is an odd number

        byte[] data = new byte[hexString.Length / 2];
        for (int index = 0; index < data.Length; index++)
        {
            string byteValue = hexString.Substring(index * 2, 2);
            data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        }
        return data;
        
    }

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = trianglespr; // gets the spriterenderer again for the third time
    }

    public void Init()
    {
        byte[] colors = ConvertHexStringToByteArray("FFAB02"); //converts hex to rgb
        randomadd = UnityEngine.Random.Range(-0.06f, 0.06f); // sets randomadd to add to value in updatecolor()
        updatecolor(); // run updatecolor to update the triangle colour at init
        m_Collider = GetComponent<Collider>(); // set collider
        clicked = 0; // set clicked to 0
        waitamount = 0; // sets waitamount to 0
        wait = 0; // sets wait to 0 
        m_MyAudioSource = GetComponent<AudioSource>(); // adds audiosource for osumode
        YSpeedMin  =  trivars.speed;  //more slider stuff
        OpacityMin =  trivars.opacity; //more slider stuff
        ScaleMin   =  trivars.smin;   //more slider stuff
        ScaleMax   =  trivars.smax;   //more slider stuff
        SpriteRenderer spRend = transform.GetComponent<SpriteRenderer>(); //Sets the spriterendererr spRend to the SpriteRenderer component.
        Color col = spRend.color; //Sets the colour "col" to spRend.color which we set just abov ethis
        FinalOpacity = OpacityMin; // Sets FinalOpacity to the minimum opacity.
        col.a = FinalOpacity; // Sets col.a (colour alpha) to the FinalOpacity 
        spRend.color = col; // Sets spRend colour to col, while your at it why not paint yourself invisible
        StartX = UnityEngine.Random.Range(-14.1f, 14.1f); //Gets X for spawn
        FinalScale = UnityEngine.Random.Range(ScaleMin, ScaleMax); //Sets FinalScale to a random number between ScaleMin and ScaleMax
        StartY = -13; //Sets startY to just off screen
        FinalSpeed = UnityEngine.Random.Range(YSpeedMin, YSpeedMax); //Sets FinalSpeed to a random number between YSpeedMin and YSpeedMax
        FinalZ = FinalScale; //Sets FinalZ to Scale, so the smaller the triangles are the closer they are to the camera, closer = smaller number
        transform.position = new Vector3(StartX,StartY,FinalZ); //Sets the position to StartX and StartY, sets Z to 0
        transform.localScale = new Vector3(FinalScale, FinalScale, 1); //Sets the scale to FinalScale
        FinalSpeed = YSpeedMin; //YSpeedMin is connected to the slider in UI called "Triangle Speed".
        FinalSpeed = FinalSpeed - (FinalScale * 5); //Make it so the smaller the triangles are the faster they move by removing the size from the speed.
        if(FinalSpeed < 0.2f) // checks if speed is too low
        {
            FinalSpeed = 0.2f; //makes speed high enough to move the triangle at an acceptable speed
        }
        // Examples
        //
        // If a triangle was the size of two, and the speed was set to 8, the speed would end out as 4.
        // Meanwhile if another triangle was set to the size of 0.2, same speed, it'd end out as 7.6
        //S_YSpeedMin.onValueChanged.AddListener(SET_S_YSMIN); // adds listeners
        //S_YSpeedMax.onValueChanged.AddListener(SET_S_YSMAX); // adds listeners
        //S_OpacityMin.onValueChanged.AddListener(SET_S_OMIN); // adds listeners
        //S_OpacityMax.onValueChanged.AddListener(SET_S_OMAX); // adds listeners
        //S_ScaleMin.onValueChanged.AddListener(SET_S_SMIN);   // adds listeners
        //S_ScaleMax.onValueChanged.AddListener(SET_S_SMAX);   // adds listeners
    }
    void Update()
    {
        updatecolor();
        //hexcodetext = hexcode.text;
        transform.position += Vector3.up * Time.deltaTime * FinalSpeed; //Moves up at speed of FinalSpeed
        if (transform.position.y >= 20) {
            Destroy(gameObject); //Destroys the gameobject if it gets too high to stop lag
        }

        if(osumodecontroller.omode == 1)
        {
            GetComponent<SpriteRenderer>().sprite = hitcircle; // gets spriterenderer and sets it to a hitcircle
            print(osumodecontroller.omode); // we off
            GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(1f, 1f, 0f, 0f, 1f, 1f); // no clue
        }
        else
        {
            //GetComponent<SpriteRenderer>().sprite = trianglespr; (commented out & moved cause it overrides replacement)

        }
        if(clicked == 1)
        {
            SpriteRenderer spRend = transform.GetComponent<SpriteRenderer>(); // gets sprite renderer
            Color col = spRend.color; // sets colour "col" to the sprite colour
            col.a -= 0.1f; // removes 0.1 from alpha
            spRend.color = col; // set sprend to col
            transform.localScale += new Vector3(1.0f, 1.0f, 1.0f) * Time.deltaTime / 2; // moves somewhere, where i dont know, i forgot
        }
        
    }
    void updatecolor()
    {
        string hextext = trivars.hex; // set "hextext" as the global variable hex (its a string, ex: AABBCC)
        if (hextext.Length < 6)
        {
            int i = 0;
            int adon = 6 - hextext.Length;
            while (i < adon)
            {
                hextext = hextext + "0";
                i++;
            }
        }
        byte[] colors = ConvertHexStringToByteArray(hextext); // sets "colors" to the hex, converted to byte array

        // colors[0] red
        // colors[1] green
        // colors[2] blue


        Color32 c = new Color32(colors[0], colors[1], colors[2], 255); // makes new color32 and sets to the R, G, and B of the converted hex, and 255 alpha
        float h, s, v; // makes 3 floats
        Color.RGBToHSV(c, out h, out s, out v); // converts color "c" to HSV
        
        v += (randomadd); // adds "randomadd" (randomized at init) to "v"
        v = Mathf.Clamp(v, 0.00f, 1.00f); // clamps it to 0-1, so it doesn't get too large
        Color c2 = Color.HSVToRGB(h, s, v); // converts back to RGB
        Color32 finalColor = new Color32((byte)(c2.r * 255), (byte)(c2.g * 255), (byte)(c2.b * 255), 255); // sets finalcolor to c2.r, c2.g, and c2.b timsed by 255
        GetComponent<Renderer>().material.color = finalColor; // sets triangle colour to finalcolor
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


   
    void OnMouseDown()
    {
        if (osumodecontroller.omode == 1) // checks if the osumode is set to 1
        {
            if (clicked == 0) // if clicked is set to... 0?
            {
                Debug.Log("Hit"); // tells me i hit something
                m_MyAudioSource.Play(); // plays hitcircle
                Destroy(gameObject, 1); // destroys hitcircle
                clicked = 1; // sets clicked to 1, now its clicked?
                m_Collider.enabled = false; // rip the collider
            }
        }
        
    }
}
