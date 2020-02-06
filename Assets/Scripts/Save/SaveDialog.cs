using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
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
    public Text hex;
    public string lang;
    public float SpawnSpeed;
    public float YSpeedMin;
    public float YSpeedMax;
    public float OpacityMin;
    public float OpacityMax;
    public float ScaleMin;
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


    void SavePressed()
    {
        // sets string "fileoutput" to all the variablenames and the variables themselves
        string fileOutput
            = "spawnspeed = "+ trivars.spawnspeed +
            "\nspeed = " + trivars.speed +
            "\nopacity = " + trivars.opacity +
            "\nsmin = " + trivars.smin +
            "\nsmax = " + trivars.smax +
            "\nhex = " + trivars.hex +
            "\nlang = " + trivars.lang
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
    void LoadPressed()
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
                string varName = ""; // sets varname to nothing.
                try // tries something
                {
                    // from this point on i have no clue
                    varName = line.Substring(0, line.IndexOf("="));
                    varName = varName.Trim();
                    string varValue = line.Substring(line.IndexOf("=") + 1);
                    varValue = varValue.Trim();
                    val = float.Parse(varValue);
                }
                catch (System.Exception e)
                {
                    Debug.LogError("Syntax error in config file" + e.Message);
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
                    // hex and lang not working for now
                    case "hex":
                        hex.text = "#ffffff";
                        break;
                    case "lang":
                        lang = val.ToString();
                        break;
                    default:
                        Debug.LogError("Unknown variable in config: " + varName);
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
