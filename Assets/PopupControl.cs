using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopupControl : MonoBehaviour
{
    public Button creditsbutt;
    public Button popupclose;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CanvasGroup>().alpha = 0;

        Button credclick = creditsbutt.GetComponent<Button>();
        credclick.onClick.AddListener(credpress);

        Button closeclick = popupclose.GetComponent<Button>();
        closeclick.onClick.AddListener(closepress);
    }

    void credpress()
    {
        GetComponent<CanvasGroup>().alpha = 1;
    }

    void closepress()
    {
        GetComponent<CanvasGroup>().alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
