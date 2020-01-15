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
    public UnityEngine.UI.Slider spawnSpeedSlider;
    public UnityEngine.UI.Slider S_YSpeedMin;
    public UnityEngine.UI.Slider S_YSpeedMax;
    public UnityEngine.UI.Slider S_OpacityMin;
    public UnityEngine.UI.Slider S_OpacityMax;
    public UnityEngine.UI.Slider S_ScaleMin;
    public UnityEngine.UI.Slider S_ScaleMax;
    public UnityEngine.UI.Slider S_SpawnSpeed;
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
        S_SpawnSpeed.onValueChanged.AddListener(SET_S_SPAWNSPEED);
        S_YSpeedMin.onValueChanged.AddListener(SET_S_YSMIN);
        S_YSpeedMax.onValueChanged.AddListener(SET_S_YSMAX);
        S_OpacityMin.onValueChanged.AddListener(SET_S_OMIN);
        S_OpacityMax.onValueChanged.AddListener(SET_S_OMAX);
        S_ScaleMin.onValueChanged.AddListener(SET_S_SMIN);
        S_ScaleMax.onValueChanged.AddListener(SET_S_SMAX);
        SpawnSpeed = S_SpawnSpeed.value;
        YSpeedMin = S_YSpeedMin.value;
        YSpeedMax = S_YSpeedMax.value;
        OpacityMin = S_OpacityMin.value;
        OpacityMax = S_OpacityMax.value;
        ScaleMin = S_ScaleMin.value;
        ScaleMax = S_ScaleMax.value;
        //tri.ScaleMax = 10; // dunno why this is here, not anymore
    }


    void SavePressed()
    {
        // sets string "fileoutput" to all the variablenames and the variables themselves
        string fileOutput = "SpawnSpeed = " + SpawnSpeed + "\nYSpeedMin = " + YSpeedMin + "\nYSpeedMax = " + YSpeedMax + "\nOpacityMin = " + OpacityMin + "\nOpacityMax = " + OpacityMax + "\nScaleMin = " + ScaleMin + "\nScaleMax = " + ScaleMax;
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
                    case "SpawnSpeed":
                        S_SpawnSpeed.value = val;
                        S_SpawnSpeed.onValueChanged.Invoke(val);
                        break;
                    case "YSpeedMin":
                        S_YSpeedMin.value = val;
                        S_YSpeedMin.onValueChanged.Invoke(val);
                        break;
                    case "YSpeedMax":
                        S_YSpeedMax.value = val;
                        S_YSpeedMax.onValueChanged.Invoke(val);
                        break;
                    case "OpacityMin":
                        S_OpacityMin.value = val;
                        S_OpacityMin.onValueChanged.Invoke(val);
                        break;
                    case "OpacityMax":
                        S_OpacityMax.value = val;
                        S_OpacityMax.onValueChanged.Invoke(val);
                        break;
                    case "ScaleMin":
                        S_ScaleMin.value = val;
                        S_ScaleMin.onValueChanged.Invoke(val);
                        break;
                    case "ScaleMax":
                        S_ScaleMax.value = val;
                        S_ScaleMax.onValueChanged.Invoke(val);
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

    void SET_S_YSMIN(float value)
    {

        YSpeedMin = value;
    }
    void SET_S_YSMAX(float value)
    {

        YSpeedMax = value;
    }
    void SET_S_OMIN(float value)
    {

        OpacityMin = value;
    }
    void SET_S_OMAX(float value)
    {

        OpacityMax = value;
    }
    void SET_S_SMIN(float value)
    {

        ScaleMin = value;
    }
    void SET_S_SMAX(float value)
    {

        ScaleMax = value;
    }
    void SET_S_SPAWNSPEED(float value)
    {

        SpawnSpeed = value;
    }
}
