using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassicTriangleManager : MonoBehaviour
{
    public Toggle mode;
    public AdvancedOptions ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trivars.classic = mode.isOn;
        if (trivars.classic == true)
        {
            ui.onofftoggle.GetComponent<Toggle>().isOn = false;
            trivars.hex = "#072552";
            trivars.backgroundhex = "#072552";
            trivars.hex = "#072552";
            Debug.Log("disabled picka");
        }
    }
}
