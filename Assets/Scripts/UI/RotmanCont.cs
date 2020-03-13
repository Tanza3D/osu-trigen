using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RotmanCont : MonoBehaviour
{
    public Button upbutt;
    public Button downbutt;
    public Button leftbutt;
    public Button rightbutt;

    // Start is called before the first frame update
    void Start()
    {
        upbutt.onClick.AddListener(rotup);
        downbutt.onClick.AddListener(rotdown);
        leftbutt.onClick.AddListener(rotleft);
        rightbutt.onClick.AddListener(rotright);
    }

    void rotup()
    {
        trivars.rotation = "up";
    }
    void rotdown()
    {
        trivars.rotation = "down";
    }
    void rotleft ()
    {
        trivars.rotation = "left";
    }
    void rotright()
    {
        trivars.rotation = "right";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
