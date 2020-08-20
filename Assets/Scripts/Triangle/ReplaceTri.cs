using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SFB;
public class ReplaceTri : MonoBehaviour
{
    public GameObject _triPrefab; //Reference To Prefab
    private string _imgLoc; //String to save file path
    public Sprite _tri; //Original Sprite

    public void LoadTri()
    {
        var extensions = new[]
        {
            new ExtensionFilter("Sprite Files", "png", "jpg", "bmp", "tga" ), //File Formats
        };

        var paths = StandaloneFileBrowser.OpenFilePanel("Open Image File", "", extensions, true); //Opens File Browser With File Formats
        if (paths.Length == 1) //Checks To See if only 1 file selected
        {
            string loc = "file://" + paths[0]; //Changes the file path into a form that unity recognises
            trivars.pngpath = loc.Replace("file://","");
            _imgLoc = loc; //terrible way to make a string global, i cba redoing it. its late :) <3
            StartCoroutine(GetSprite()); //Starts co-routine to change sprites

        }
    }
    IEnumerator GetSprite()
    {
        Debug.Log("imgloc: " + _imgLoc);
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
                Sprite sprite = Sprite.Create(DownloadHandlerTexture.GetContent(www), rect, new Vector2(0.5f,0.5f)); //Creates new sprite
                _triPrefab.GetComponent<SpriteRenderer>().sprite = sprite; //Overrites the tri prefab sprite
                _triPrefab.GetComponent<Triangle>().trianglespr = sprite; //^^
            }
        }
    }
}



















// Haha 69 funny get it? go sub pls thnx <3 http://www.youtube.com/BradCubed