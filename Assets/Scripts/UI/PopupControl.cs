using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopupControl : MonoBehaviour
{
    
    public Button popupclose;
    public Button creditsbutt;
    public Button privacybutt;
    public Button websitebutt;
    public Button sourcebutt;

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

        Button webclick = websitebutt.GetComponent<Button>();
        webclick.onClick.AddListener(webpress);

        Button sourceclick = sourcebutt.GetComponent<Button>();
        sourceclick.onClick.AddListener(sourcepress);
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
        Application.OpenURL("https://eclipsed.hubza.co.uk/programs/osutrigen/trigen-privacy-policy");
    }

    void sourcepress()
    {
        Application.OpenURL("https://github.com/eclipsedteam/osu-trigen/");
    }

    void webpress()
    {
        Application.OpenURL("https://eclipsed.hubza.co.uk/programs/osutrigen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
