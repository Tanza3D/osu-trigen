using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class background : MonoBehaviour
{
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updatecolor();
    }

    void updatecolor()
    {
        string hextext = trivars.hex; // set "hextext" as the global variable hex (its a string, ex: AABBCC)
        byte[] colors = ConvertHexStringToByteArray(hextext); // sets "colors" to the hex, converted to byte array

        // colors[0] red
        // colors[1] green
        // colors[2] blue


        Color32 c = new Color32(colors[0], colors[1], colors[2], 255); // makes new color32 and sets to the R, G, and B of the converted hex, and 255 alpha
        float h, s, v; // makes 3 floats
        Color.RGBToHSV(c, out h, out s, out v); // converts color "c" to HSV
        v = Mathf.Clamp(v, 0.00f, 1.00f); // clamps it to 0-1, so it doesn't get too large
        Color c2 = Color.HSVToRGB(h, s, v); // converts back to RGB
        Color32 finalColor = new Color32((byte)(c2.r * 255), (byte)(c2.g * 255), (byte)(c2.b * 255), 255); // sets finalcolor to c2.r, c2.g, and c2.b timsed by 255
        GetComponent<Renderer>().material.color = finalColor; // sets triangle colour to finalcolor
    }
}
