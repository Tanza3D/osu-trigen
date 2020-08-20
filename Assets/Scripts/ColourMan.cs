using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
using System.IO;
using System.Globalization;
using System.Threading;
using System;
using UnityEditor;

public class ColourMan : MonoBehaviour
{
    IEnumerator checkInternetConnection(Action<bool> action)
    {
        WWW www = new WWW("http://eclipsed.hubza.co.uk");
        yield return www;
        if (www.error != null)
        {
            action(true);
        }
        else
        {
            action(false);
        }
    }

    public Text debug;
    public ThemeInitiator themeinit;
    public Color accent;
    public Color pancol;
    public Color textcol;
    public Color buttcol;

    public Color orig_accent;
    public Color orig_pancol;
    public Color orig_textcol;
    public Color orig_buttcol;

    public Button resetbutt;
    public Button savebutt;
    public Button loadbutt;
    public Button hidebutt;

    public float accentr  ;
    public float pancolr  ;
    public float textcolr ;
    public float buttcolr ;
    public float accentg  ;
    public float pancolg  ;
    public float textcolg ;
    public float buttcolg ;
    public float accentb  ;
    public float pancolb  ;
    public float textcolb ;
    public float buttcolb ;

    public float orig_accentr;
    public float orig_pancolr;
    public float orig_textcolr;
    public float orig_buttcolr;
    public float orig_accentg;
    public float orig_pancolg;
    public float orig_textcolg;
    public float orig_buttcolg;
    public float orig_accentb;
    public float orig_pancolb;
    public float orig_textcolb;
    public float orig_buttcolb;

    public Slider sld_accentr;
    public Slider sld_pancolr;
    public Slider sld_textcolr;
    public Slider sld_buttcolr;
    public Slider sld_accentg;
    public Slider sld_pancolg;
    public Slider sld_textcolg;
    public Slider sld_buttcolg;
    public Slider sld_accentb;
    public Slider sld_pancolb;
    public Slider sld_textcolb;
    public Slider sld_buttcolb;

    public Dropdown themesdropdown;


    public bool showPopUp;
    void OnGUI()
    {
        if (showPopUp)
        {
            GUI.Window(0, new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75
                   , 300, 250), ShowGUI, "Theme Missing");

        }
    }
    void ShowGUI(int windowID)
    {
        // You may put a label to show a message to the player

        GUI.Label(new Rect(65, 40, 200, 90), "The theme you just tried to load, " + themesdropdown.options[themesdropdown.value].text + ", seems to be missing from the themes folder. Please confirm the theme is in the correct location and try again.");

        // You may put a button to close the pop up too

        if (GUI.Button(new Rect(50, 150, 75, 30), "Alright"))
        {
            showPopUp = false;
            // you may put other code to run according to your game too
        }

    }

    void DropdownValueChanged(Dropdown themesdropdown)
    {
        

        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string docPath = appdata + "\\trigen\\themes\\";
        string fullpath = docPath + themesdropdown.options[themesdropdown.value].text;
        Debug.Log(fullpath);

        if (!System.IO.File.Exists(fullpath))
        {
            showPopUp = true;
        }

        foreach (string line in File.ReadLines(fullpath))
        {
            Debug.Log("file.readlines fullpath: " + File.ReadLines(fullpath));
            float val = 0.0f;
            string varName = "";
            try
            {
                varName = line.Substring(0, line.IndexOf("="));
                varName = varName.Trim();
                string varValue = line.Substring(line.IndexOf("=") + 1);
                varValue = varValue.Trim();
                val = float.Parse(varValue);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Syntax error in config file: " + e.Message);
                return;
            }
            switch (varName)
            {
                // still no clue sorry
                case "accentr":
                    sld_accentr.value = val;
                    break;
                case "pancolr":
                    sld_pancolr.value = val;
                    break;
                case "textcolr":
                    sld_textcolr.value = val;
                    break;
                case "buttcolr":
                    sld_buttcolr.value = val;
                    break;
                case "accentg":
                    sld_accentg.value = val;
                    break;
                case "pancolg":
                    sld_pancolg.value = val;
                    break;
                case "textcolg":
                    sld_textcolg.value = val;
                    break;
                case "buttcolg":
                    sld_buttcolg.value = val;
                    break;
                case "accentb":
                    sld_accentb.value = val;
                    break;
                case "pancolb":
                    sld_pancolb.value = val;
                    break;
                case "textcolb":
                    sld_textcolb.value = val;
                    break;
                case "buttcolb":
                    sld_buttcolb.value = val;
                    break;
                default:
                    Debug.LogError("Unknown variable in config: " + varName);
                    break;
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        themesdropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(themesdropdown);
        });


        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us"); // use dot instead of comma

        sld_accentr.value = 1;
        sld_accentg.value = 0.4f;
        sld_accentb.value = 0.67058823529f;

        sld_pancolr.value = 1;
        sld_pancolg.value = 1;
        sld_pancolb.value = 1;

        sld_textcolr.value = 0.14901960784f;
        sld_textcolg.value = 0.05098039215f;
        sld_textcolb.value = 0.09411764705f;

        sld_buttcolr.value = 1;
        sld_buttcolg.value = 1;
        sld_buttcolb.value = 1;

        orig_accentr  =  sld_accentr.value;
        orig_pancolr  =  sld_pancolr.value;
        orig_textcolr =  sld_textcolr.value;
        orig_buttcolr =  sld_buttcolr.value;
        orig_accentg  =  sld_accentg.value;
        orig_pancolg  =  sld_pancolg.value;
        orig_textcolg =  sld_textcolg.value;
        orig_buttcolg =  sld_buttcolg.value;
        orig_accentb  =  sld_accentb.value;
        orig_pancolb  =  sld_pancolb.value;
        orig_textcolb =  sld_textcolb.value;
        orig_buttcolb =  sld_buttcolb.value;

        resetbutt.onClick.AddListener(resetcol);


        savebutt.onClick.AddListener(SavePressed);
        loadbutt.onClick.AddListener(LoadPressed);

        //hidebutt.onClick.AddListener(HideShowUI);

        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
    }

    // Update is called once per frame


    void HideShowUI()
    {
        if (GetComponent<CanvasGroup>().alpha == 1)
        {
            GetComponent<CanvasGroup>().alpha = 0;
            GetComponent<CanvasGroup>().interactable = false;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = 1;
            GetComponent<CanvasGroup>().interactable = true;
        }
    }
    void Update()
    {
        accentr =  sld_accentr  .value;
        pancolr =  sld_pancolr  .value;
        textcolr = sld_textcolr .value;
        buttcolr = sld_buttcolr .value;
        accentg =  sld_accentg  .value;
        pancolg =  sld_pancolg  .value;
        textcolg = sld_textcolg .value;
        buttcolg = sld_buttcolg .value;
        accentb =  sld_accentb  .value;
        pancolb =  sld_pancolb  .value;
        textcolb = sld_textcolb .value;
        buttcolb = sld_buttcolb .value;

        accent = new Color(accentr, accentg, accentb);
        pancol = new Color(pancolr, pancolg, pancolb);
        textcol = new Color(textcolr, textcolg, textcolb);
        buttcol = new Color(buttcolr, buttcolg, buttcolb);

        // Set Colour of Images (accent)
        GameObject[] objs;
        objs = GameObject.FindGameObjectsWithTag("ColourUI");
        foreach (GameObject owo in objs)
        {
            owo.GetComponent<Image>().color = accent;
        }
        // Set Colour of accent texts (accent)
        GameObject[] objs2;
        objs2 = GameObject.FindGameObjectsWithTag("ColourText");
        foreach (GameObject owo in objs2)
        {
            owo.GetComponent<Text>().color = accent;
        }
        // Set Colour of Panels (pancol)
        GameObject[] objs3;
        objs3 = GameObject.FindGameObjectsWithTag("pancol");
        foreach (GameObject owo in objs3)
        {
            owo.GetComponent<Image>().color = pancol;
        }
        // Set Colour of texts (textcol)
        GameObject[] objs4;
        objs4 = GameObject.FindGameObjectsWithTag("textcol");
        foreach (GameObject owo in objs4)
        {
            var script4 = owo.GetComponent<Text>();
            if (script4 != null)
            {
                owo.GetComponent<Text>().color = textcol;
            }
            var script3 = owo.GetComponent<Image>();
            if (script3 != null)
            {
                owo.GetComponent<Image>().color = textcol;
            }
        }
        // Set Colour of butttexts (buttext)
        GameObject[] objs5;
        objs5 = GameObject.FindGameObjectsWithTag("buttext");
        foreach (GameObject owo in objs5)
        {
            var script = owo.GetComponent<Text>();
            if (script != null)
            {
                owo.GetComponent<Text>().color = buttcol;
            }
            var script2 = owo.GetComponent<Image>();
            if (script2 != null)
            {   
                owo.GetComponent<Image>().color = buttcol;
            }


        }
        GameObject[] objs6;
        objs6 = GameObject.FindGameObjectsWithTag("HexTag");
        foreach (GameObject owo in objs6)
        {
            owo.GetComponent<Text>().color = buttcol;
        }


    }

    public void resetcol()
    {
        themeinit.addfilestoarray();
        sld_accentr.value = orig_accentr;
        sld_pancolr.value   = orig_pancolr   ;
        sld_textcolr.value = orig_textcolr  ;
        sld_buttcolr.value = orig_buttcolr  ;
        sld_accentg.value   = orig_accentg   ;
        sld_pancolg.value   = orig_pancolg   ;
        sld_textcolg.value = orig_textcolg  ;
        sld_buttcolg.value = orig_buttcolg  ;
        sld_accentb.value   = orig_accentb   ;
        sld_pancolb.value   = orig_pancolb   ;
        sld_textcolb.value = orig_textcolb  ;
        sld_buttcolb.value = orig_buttcolb  ;
    }

 
    public void SavePressed()
    {
        // sets string "fileoutput" to all the variablenames and the variables themselves
        string fileOutput
            //sld_accentr.value
            //sld_pancolr.value
            //sld_textcolr.value
            //sld_buttcolr.value
            //sld_accentg.value
            //sld_pancolg.value
            //sld_textcolg.value
            //sld_buttcolg.value
            //sld_accentb.value
            //sld_pancolb.value
            //sld_textcolb.value
            //sld_buttcolb.value
            
            = "accentr = " + accentr +
            "\npancolr = " + pancolr +
            "\ntextcolr = " + textcolr +
            "\nbuttcolr = " + buttcolr +
            "\naccentg = " + accentg +
            "\npancolg = " + pancolg +
            "\ntextcolg = " + textcolg +
            "\nbuttcolg = " + buttcolg +
            "\naccentb = " + accentb +
            "\npancolb = " + pancolb +
            "\ntextcolb = " + textcolb +
            "\nbuttcolb = " + buttcolb 
            ;
        // opens panel
        var path = StandaloneFileBrowser.SaveFilePanel("Save osu!trigen Theme file as .tgt", "", "theme", "tgt");
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
        var paths = StandaloneFileBrowser.OpenFilePanel("Load osu!trigen Theme file (.tgt)", "", "tgt", false);

        // detects if path exists
        if (paths.Length > 0)
        {

            // not sure what this does
            foreach (string line in File.ReadLines(paths[0]))
            {
                float val = 0.0f;
                string varName = "";
                try
                {
                    varName = line.Substring(0, line.IndexOf("="));
                    varName = varName.Trim();
                    string varValue = line.Substring(line.IndexOf("=") + 1);
                    varValue = varValue.Trim();
                    val = float.Parse(varValue);
                }
                catch (System.Exception e)
                {
                    Debug.LogError("Syntax error in config file: " + e.Message);
                    return;
                }
                switch (varName)
                {
                    // still no clue sorry
                    case "accentr":
                        sld_accentr.value = val;
                        break;
                    case "pancolr":
                        sld_pancolr.value = val;
                        break;
                    case "textcolr":
                        sld_textcolr.value = val;
                        break;
                    case "buttcolr":
                        sld_buttcolr.value = val;
                        break;
                    case "accentg":
                        sld_accentg.value = val;
                        break;
                    case "pancolg":
                        sld_pancolg.value = val;
                        break;
                    case "textcolg":
                        sld_textcolg.value = val;
                        break;
                    case "buttcolg":
                        sld_buttcolg.value = val;
                        break;
                    case "accentb":
                        sld_accentb.value = val;
                        break;
                    case "pancolb":
                        sld_pancolb.value = val;
                        break;
                    case "textcolb":
                        sld_textcolb.value = val;
                        break;
                    case "buttcolb":
                        sld_buttcolb.value = val;
                        break;
                    default:
                        Debug.LogError("Unknown variable in config: " + varName);
                        break;
                }

            }
        }


    }

    

}
