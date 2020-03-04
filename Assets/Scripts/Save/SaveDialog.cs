using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;


using UnityEngine.Networking;

using System.IO;

public class SaveDialog : MonoBehaviour
{
    public Button SaveButton;
    public Button LoadButton;
    public GameObject trispawner;
    private string _data = "";
    public Text output;
    public GameObject tri;
    public UnityEngine.UI.Slider S_Spawnspeed;
    public UnityEngine.UI.Slider S_Speed;
    public UnityEngine.UI.Slider S_Opacity;
    public UnityEngine.UI.Slider S_Smin;
    public UnityEngine.UI.Slider S_Smax;

    public UnityEngine.UI.Slider S_CVAdd;
    public UnityEngine.UI.Slider S_CVRem;
    public InputField hex;
    public string lang;
    public string result;
    public float SpawnSpeed;
    public float YSpeedMin;
    public float YSpeedMax;
    public float OpacityMin;
    public float OpacityMax;
    public float ScaleMin;

    public string thepngpath;

    public float ScaleMax;
    public float BackgroundHex;
    public float LoadedSpawnSpeed;
    public float LoadedYSpeedMin;
    public float LoadedYSpeedMax;
    public float LoadedOpacityMin;
    public float LoadedOpacityMax;
    public float LoadedScaleMin;
    public float LoadedScaleMax;
    public float FinalSpeed;
    public float FinalScale;
    public float FinalOpacity;
    public bool tryparsething;
    public Toggle seperatepicker;
    public InputField bghex;

    // tri replacement
    public GameObject _triPrefab; //Reference To Prefab
    private string _imgLoc; //String to save file path
    public Sprite _tri; //Original Sprite

    //S_YSpeedMin;
    //S_YSpeedMax;
    //S_OpacityMin;
    //S_OpacityMax;
    //S_ScaleMin;
    //S_ScaleMax;

    // Start is called before the first frame update
    void Start()
    {
        SaveButton.onClick.AddListener(SavePressed);
        LoadButton.onClick.AddListener(LoadPressed);
        //tri.ScaleMax = 10; // dunno why this is here, not anymore
    }


    public void SavePressed()
    {
        
        // sets string "fileoutput" to all the variablenames and the variables themselves
        string fileOutput
            = "spawnspeed = "+ trivars.spawnspeed +
            "\nspeed = " + trivars.speed +
            "\nopacity = " + trivars.opacity +
            "\nsmin = " + trivars.smin +
            "\nsmax = " + trivars.smax +
            "\ncvadd = " + trivars.CVAdd +
            "\ncvrem = " + trivars.CVRem +
            "\nhex = " + trivars.hex +
            "\npngpath = " + trivars.pngpath +
            "\nbackgroundpath = " + trivars.backgroundpath +
            "\nlang = " + trivars.lang +
            "\nbghex = " + trivars.backgroundhex +
            "\nbgtoggle = " + trivars.seperatepicker
            ;
        // opens panel
        var path = StandaloneFileBrowser.SaveFilePanel("Save TriGen config file as .tgcf", "", "config", "tgcf");
        // detects if path is empty 
        if (!string.IsNullOrEmpty(path))
        {
            // dunno what this does
            File.WriteAllText(path, fileOutput);
        }
        print("Save has been Pressed"); //needs to be a debug log now
    }
    public void LoadPressed()
    {
        // opens browser
        var paths = StandaloneFileBrowser.OpenFilePanel("Load Trigen config file (.tgcf)", "", "tgcf", false);

        // detects if path exists
        if (paths.Length > 0)
        {

            // not sure what this does
            foreach (string line in File.ReadLines(paths[0]))
            {
                float val = 0.0f; // sets val to 0.0, obvious
                string result = "RESULT"; //sets the string result to result, obvious
                string varName = ""; // sets varname to nothing.
                string varValue = ""; // NEW: Move VarValue up here so it can be read from the switch

                try // tries something
                {
                    // from this point on i have no clue
                    varName = line.Substring(0, line.IndexOf("="));
                    varName = varName.Trim();
                    varValue = line.Substring(line.IndexOf("=") + 1);
                    varValue = varValue.Trim();
                    tryparsething = float.TryParse(varValue, out val); // NEW: TryParse doesn't throw exception on fail...
                    result = varValue;
                }
                catch (System.Exception e)
                {
                    Debug.LogError("Syntax error in config file: " + e.Message);
                    return;
                }
                switch (varName)
                {
                    // still no clue sorry
                    case "spawnspeed":
                        S_Spawnspeed.value = val;
                        break;
                    case "speed":
                        S_Speed.value = val;
                        break;
                    case "opacity":
                        S_Opacity.value = val;
                        break;
                    case "smin":
                        S_Smin.value = val;
                        break;
                    case "smax":
                        S_Smax.value = val;
                        break;
                    case "cvadd":
                        S_CVAdd.value = val;
                        break;
                    case "cvrem":
                        S_CVRem.value = -val;
                        break;
                    // hex and lang not working for now
                    case "hex":
                        Debug.Log(varValue);
                        hex.text = varValue;
                        break;
                    case "pngpath":
                        Debug.Log(varValue);
                        thepngpath = varValue;
                        LoadTri(thepngpath);
                        break;
                    case "bghex":
                        Debug.Log(varValue);
                        bghex.text = varValue;
                        break;
                    case "bgtoggle":
                        Debug.Log(varValue);
                        seperatepicker.GetComponent<Toggle>().isOn = true;
                        break;
                    case "lang":
                        lang = varValue;
                        break;
                    default:
                        Debug.LogError("Unknown variable in config: " + varName);
                        break;
                }
                
            }
        }
    }

    public void LoadTri(string lepath)
    {
            string loc = "file://" + lepath; //Changes the file path into a form that unity recognises
            trivars.pngpath = loc;
            Debug.Log("loc: " + loc);
            _imgLoc = loc; //terrible way to make a string global, i cba redoing it. its late :) <3
            StartCoroutine(GetSprite()); //Starts co-routine to change sprites
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
                Sprite sprite = Sprite.Create(DownloadHandlerTexture.GetContent(www), rect, new Vector2(0.5f, 0.5f)); //Creates new sprite
                _triPrefab.GetComponent<SpriteRenderer>().sprite = sprite; //Overrites the tri prefab sprite
                _triPrefab.GetComponent<Triangle>().trianglespr = sprite; //^^
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
