using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public GameObject Light1;
    public GameObject Light2;
    public UnityEngine.UI.Toggle SpecialLightToggle;
    // Start is called before the first frame update
    void Start()
    {
        SpecialLightToggle.onValueChanged.AddListener((value) =>
        {
            Switched(value);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switched(bool value)
    {
        if (value)
        {
            print("ToggleOn");
            Light1.SetActive(true);
            Light2.SetActive(false);
        }
        else
        {
            print("ToggleOff");
            Light1.SetActive(false);
            Light2.SetActive(true);
        }

    }
}
