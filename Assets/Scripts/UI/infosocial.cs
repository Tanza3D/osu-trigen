using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class infosocial : MonoBehaviour
{
    public Button twitter;
    public Button github;
    public Button msstore;
    public Button discord;

    // Start is called before the first frame update
    void Start()
    {
        twitter.onClick.AddListener(tclick);

        github.onClick.AddListener(gclick);

        msstore.onClick.AddListener(msclick);

        discord.onClick.AddListener(dclick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tclick()
    {
        Application.OpenURL("https://twitter.com/eclipsed_team");
    }

    public void gclick()
    {
        Application.OpenURL("https://github.com/eclipsedteam/");
    }

    public void msclick()
    {
        Application.OpenURL("https://www.microsoft.com/store/productId/9NKXLZWSLS1T");
    }

    public void dclick()
    {
        Application.OpenURL("https://discord.gg/QDYWZPS");
    }
}
