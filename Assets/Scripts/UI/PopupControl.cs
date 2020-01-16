using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopupControl : MonoBehaviour
{
    public Button creditsbutt;
    public Button popupclose;
    public Button privacybutt;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CanvasGroup>().alpha = 0;

        Button credclick = creditsbutt.GetComponent<Button>();
        credclick.onClick.AddListener(credpress);

        Button closeclick = popupclose.GetComponent<Button>();
        closeclick.onClick.AddListener(closepress);

        Button privacyclick = privacybutt.GetComponent<Button>();
        privacyclick.onClick.AddListener(privacypress);
    }

    void credpress()
    {
        GetComponent<CanvasGroup>().alpha = 1;
    }

    void closepress()
    {
        GetComponent<CanvasGroup>().alpha = 0;
    }

    void privacypress()
    {
        Application.OpenURL("https://eclipsed.hubza.co.uk/trigen-privacy-policy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
