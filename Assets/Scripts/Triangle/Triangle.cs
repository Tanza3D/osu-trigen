using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Globalization;
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
    public Sprite hitcircle;
    public Sprite trianglespr;
    public Text hexcode;

    public float randomadd;
    public float wait;
    public float waitamount;
    public float colors;
    public string hextext;
    public float clicked;

    public float finalspeedsaved;

    public GameObject selectionbox;

    public string hexcodetext;

    public Color32 classic;
    public SpriteRenderer sr;

    // TRIGEN TRIANGLE V3

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
        sr = this.GetComponent<SpriteRenderer>();
        sr.sprite = trianglespr; // gets the spriterenderer again for the third time
    }

    public static Color32 hexToColor(string hex)
    {
        hex = hex.Replace("0x", "");//in case the string is formatted 0xFFFFFF
        hex = hex.Replace("#", "");//in case the string is formatted #FFFFFF
        byte a = 255;//assume fully visible unless specified in hex
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        //Only use alpha if the string has enough characters
        if (hex.Length == 8)
        {
            a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
        }
        return new Color32(r, g, b, a);
    }

    public void Init()
    {
        Color32[] tricols;
        tricols = new Color32[]{
            hexToColor("2f669f"),
            hexToColor("ffc454"),
            hexToColor("ff044d"),
            hexToColor("970059"),
            hexToColor("e7e7e7")
        };
        classic = tricols[UnityEngine.Random.Range(0, tricols.Length)];
        
        byte[] colors = ConvertHexStringToByteArray("FFAB02"); //converts hex to rgb


        randomadd = UnityEngine.Random.Range(trivars.CVRem, trivars.CVAdd); // sets randomadd to add to value in updatecolor()

        clicked = 0; // set clicked to 0
        waitamount = 0; // sets waitamount to 0
        wait = 0; // sets wait to 0 
        YSpeedMin  =  trivars.speed;  //more slider stuff
        OpacityMin =  trivars.opacity; //more slider stuff
        ScaleMin   =  trivars.smin;   //more slider stuff
        ScaleMax   =  trivars.smax;   //more slider stuff
       
        Color col = sr.color; //Sets the colour "col" to spRend.color which we set just abov ethis
        FinalOpacity = OpacityMin; // Sets FinalOpacity to the minimum opacity.
        col.a = FinalOpacity; // Sets col.a (colour alpha) to the FinalOpacity 
        sr.color = col; // Sets spRend colour to col, while your at it why not paint yourself invisible
   
        FinalScale = UnityEngine.Random.Range(ScaleMin, ScaleMax); //Sets FinalScale to a random number between ScaleMin and ScaleMax
        FinalSpeed = UnityEngine.Random.Range(YSpeedMin, YSpeedMax); //Sets FinalSpeed to a random number between YSpeedMin and YSpeedMax
        FinalZ = FinalScale; //Sets FinalZ to Scale, so the smaller the triangles are the closer they are to the camera, closer = smaller number
        
        transform.localScale = new Vector3(FinalScale, FinalScale, 1); //Sets the scale to FinalScale
        if (trivars.rotation == "up")
        {
            StartX = UnityEngine.Random.Range(-18.1f, 18.1f); //Gets X for spawn
            StartY = -13;
            transform.position = new Vector3(StartX, StartY, FinalZ); //Sets the position to StartX and StartY, sets Z to 0
        }
        if (trivars.rotation == "down")
        {
            StartX = UnityEngine.Random.Range(-18.1f, 18.1f); //Gets X for spawn
            StartY = 13;
            transform.position = new Vector3(StartX, StartY, FinalZ); //Sets the position to StartX and StartY, sets Z to 0
        }
        if (trivars.rotation == "right")
        {
            StartY = UnityEngine.Random.Range(-18.1f, 18.1f); //Gets X for spawn
            StartX = -13;
            transform.position = new Vector3(StartX, StartY, FinalZ); //Sets the position to StartX and StartY, sets Z to 0
        }
        if (trivars.rotation == "left")
        {
            StartY = UnityEngine.Random.Range(-18.1f, 18.1f); //Gets height for spawn
            StartX = 13;
            transform.position = new Vector3(StartX, StartY, FinalZ); //Sets the position to StartX and StartY, sets Z to 0
        }
        FinalSpeed = YSpeedMin; //YSpeedMin is connected to the slider in UI called "Triangle Speed".
        FinalSpeed = FinalSpeed - (FinalScale * 5); //Make it so the smaller the triangles are the faster they move by removing the size from the speed.
        if(FinalSpeed < 0.2f) // checks if speed is too low
        {
            FinalSpeed = 0.2f; //makes speed high enough to move the triangle at an acceptable speed
        }
        updatecolor(); // run updatecolor to update the triangle colour at init
    }

    void Update()
    {
        updatecolor();
        //hexcodetext = hexcode.text;

        if (trivars.tripaused == false)
        {
            if (trivars.rotation == "up")
            {
                transform.position += Vector3.up * Time.deltaTime * FinalSpeed * (trivars.songvol); //Moves up at speed of FinalSpeed
                if (transform.position.y >= 20)
                {
                    Destroy(gameObject); //Destroys the gameobject if it gets too high to stop lag
                }
            }
            if (trivars.rotation == "down")
            {
                transform.position -= Vector3.up * Time.deltaTime * FinalSpeed * (trivars.songvol); //Moves up at speed of FinalSpeed
                if (transform.position.y <= -20)
                {
                    Destroy(gameObject); //Destroys the gameobject if it gets too high to stop lag
                }
            }
            if (trivars.rotation == "right")
            {
                transform.position += Vector3.right * Time.deltaTime * FinalSpeed * (trivars.songvol); //Moves up at speed of FinalSpeed
                if (transform.position.x >= 20)
                {
                    Destroy(gameObject); //Destroys the gameobject if it gets too high to stop lag
                }
            }
            if (trivars.rotation == "left")
            {
                transform.position += Vector3.left * Time.deltaTime * FinalSpeed * (trivars.songvol); //Moves up at speed of FinalSpeed
                if (transform.position.x <= -20)
                {
                    Destroy(gameObject); //Destroys the gameobject if it gets too far left to stop lag
                }
            }
        }
    }
    void updatecolor()
    {
        if (trivars.classic == false)
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
        else
        {
            GetComponent<Renderer>().material.color = classic;
        }
    }
}
