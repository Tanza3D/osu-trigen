using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    float Scale;
    float XPosition;
    float Speed;
    public SpriteRenderer renderer;
    float colourVariance;
    // Start is called before the first frame update
    void Start()
    {
        Respawn();
    }

    void Respawn(bool atBottom = false)
    {
        Scale = Random.Range(0f, 1f);
        XPosition = Random.Range(-1f, 1f);
        Speed = Random.Range(0f, 1f);

        if (atBottom == false)
        {
            Vector2 topLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
            Vector2 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height));
            Debug.Log("top left is " + topLeft);
            Debug.Log("bottom left is " + bottomLeft);

            float spawnY = Random.Range(topLeft.y, bottomLeft.y);
            transform.position = new Vector3(0, spawnY, 0);
        }else
        {
            Vector2 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
            transform.position = new Vector3(0, bottomLeft.y - 3, 0);
        }
        renderer.color = new Color(0, 0, 0, 0);

        colourVariance = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float multiplier = (Global_Options.Triangle.MaxScale - (transform.localScale.x*2)) * Global_Options.Triangle.SpeedMultiplier;
        float upwards = ((Global_Options.Triangle.Speed / 300) * multiplier) * Time.deltaTime;

        float finalX = XPosition;
        //Vector2 topLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        Vector2 topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        
        finalX *= topRight.x;
        transform.position = new Vector3(finalX, transform.position.y + upwards, 0);

        float finalScale = ExtensionMethods.Remap(Scale, 0, 1, Global_Options.Triangle.MinScale, Global_Options.Triangle.MaxScale)/10;
        transform.localScale = new Vector3(finalScale, finalScale, finalScale);

        float hue;
        float saturation;
        float value;
        Color.RGBToHSV(Global_Options.Triangle.Colour.TriangleColour, out hue, out saturation, out value);
        float HSVValueChange = ExtensionMethods.Remap(colourVariance, -1f, 1f, Global_Options.Triangle.Colour.ColourVarianceDown, Global_Options.Triangle.Colour.ColourVarianceUp);
        value += HSVValueChange;
        renderer.color = Color.HSVToRGB(hue, saturation, value);

        //renderer.color = new Color(1, 1, 1, 1);



        if (transform.position.y > topRight.y + (transform.localScale.x*2.1f))
        {
            Respawn(true);
            Debug.Log("respawning! - position is " + transform.position.y + " and topRight.y is " + topRight.y);
        }
    }
}

