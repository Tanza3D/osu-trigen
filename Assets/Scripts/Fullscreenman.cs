using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreenman : MonoBehaviour
{
    public GameObject onofftoggle;
    public bool clicked;

    // Start is called before the first frame update
    void Start()
    {
        onofftoggle.GetComponent<Toggle>().onValueChanged.AddListener(delegate {
            ToggleValueChanged(onofftoggle.GetComponent<Toggle>());
        });

    }



    void ToggleValueChanged(Toggle change)
    {
        if (onofftoggle.GetComponent<Toggle>().isOn == true)
        {
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
            Screen.fullScreen = true;
        }
        if (onofftoggle.GetComponent<Toggle>().isOn == false)
        {
            Screen.SetResolution(1366, 768, true);
            Screen.fullScreen = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
