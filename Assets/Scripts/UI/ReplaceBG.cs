using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SFB;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ReplaceBG : MonoBehaviour
{

    public GameObject _defaultBG;
    private string _imgLoc;
    public Canvas _bg;
    public Button resetbutt; // bradcubed uses onclick in the inspector, but i use this, no clue how to use onclick so using this -hubz
    public void LoadBG()
    {
        var extensions = new[]
        {
            new ExtensionFilter("Sprite Files", "png", "jpg", "bmp", "tga" ), //File Formats
        };

        var paths = StandaloneFileBrowser.OpenFilePanel("Open Image File", "", extensions, true); //Opens File Browser With File Formats
        if (paths.Length == 1) //Checks To See if only 1 file selected
        {
            string loc = "file://" + paths[0]; //Changes the file path into a form that unity recognises
            trivars.backgroundpath = loc;
            _imgLoc = loc; //terrible way to make a string global, i cba redoing it. its late :) <3
            StartCoroutine(GetSprite()); //Starts co-routine to change sprites
        }
        if(_defaultBG.activeInHierarchy)
        {
            _defaultBG.SetActive(false);
            _bg.gameObject.SetActive(true);
        }
    }

    public void Start()
    {
        resetbutt.onClick.AddListener(ResetBG);
    }

    public void ResetBG()
    {
        _defaultBG.SetActive(true);
        _bg.gameObject.SetActive(false);
    }

    IEnumerator GetSprite()
    {
        using (UnityWebRequest www = UnityWebRequestTexture.GetTexture(_imgLoc)) //"Downloads" (unity be stupid), the texture so we can create it _imgLoc is the filepath for the opened image
        {
            yield return www.SendWebRequest(); //Sends request to get image file
            if (www.isNetworkError)
            {
                Debug.Log(www.error); //error return stuffs
            }
            else
            {
                Rect rect = new Rect(); //Creates new rect for texture
                rect.x = 0; //init stuff
                rect.y = 0; //^^
                rect.width = DownloadHandlerTexture.GetContent(www).width; //Sets the rect dimensions to image resolution
                rect.height = DownloadHandlerTexture.GetContent(www).height; //^^
                Sprite sprite = Sprite.Create(DownloadHandlerTexture.GetContent(www), rect, new Vector2(0.5f, 0.5f)); //Creates new sprite
                _bg.GetComponentInChildren<Image>().sprite = sprite;
            }
        }
    }
}
