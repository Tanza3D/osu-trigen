using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BGColourPickerController : MonoBehaviour
{
    public Toggle SeperatePicker;
    public Text backgroundhextext;
    public Text Colourpickertext;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SeperatePicker.isOn)
        {
            trivars.backgroundhex = backgroundhextext.text.Replace("#", "");
            trivars.seperatepicker = true;
            Colourpickertext.text = "Triangle Colour";
            GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            trivars.backgroundhex = backgroundhextext.text.Replace("#", "");
            trivars.seperatepicker = false;
            Colourpickertext.text = "Colour Picker";
            GetComponent<CanvasGroup>().alpha = 0;
        }
    }
}
