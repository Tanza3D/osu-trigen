using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pauseman : MonoBehaviour
{
    public GameObject onofftoggle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onofftoggle.GetComponent<Toggle>().isOn == true)
        {
            trivars.tripaused = true;
        }
        else
        {
            trivars.tripaused = false;
        }
    }
}
