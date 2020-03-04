using UnityEngine;
using System;
using System.Text;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using UnityEngine.UI;
using System.Net;


public class ThemeInitiator : MonoBehaviour
{
    private WWW www;
    private bool isUnzipped = false;
    public Dropdown themes;
    public Text debug;
    public string toadd;
    public ColourMan colourman;
    public GameObject colcontrol;
    public Button open;
    // Start is called before the first frame update


    public string GetHtmlFromUri(string resource)
    {
        string html = string.Empty;
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(resource);
        try
        {
            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                bool isSuccess = (int)resp.StatusCode < 299 && (int)resp.StatusCode >= 200;
                if (isSuccess)
                {
                    using (StreamReader reader = new StreamReader(resp.GetResponseStream()))
                    {
                        //We are limiting the array to 80 so we don't have
                        //to parse the entire html document feel free to 
                        //adjust (probably stay under 300)
                        char[] cs = new char[80];
                        reader.Read(cs, 0, cs.Length);
                        foreach (char ch in cs)
                        {
                            html += ch;
                        }
                    }
                }
            }
        }
        catch
        {
            return "";
        }
        return html;
    }

    public bool showPopUp;
    void OnGUI()
    {
        if (showPopUp)
        {
            GUI.Window(0, new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75
                   , 300, 250), ShowGUI, "Not Connected");

        }
    }
    void ShowGUI(int windowID)
    {
        // You may put a label to show a message to the player

        GUI.Label(new Rect(65, 40, 200, 90), "You are not connected to the internet, this means that new default themes wont be downloaded until you do. Keep in mind that to download new themes you'll need to restart osu!trigen.");

        // You may put a button to close the pop up too

        if (GUI.Button(new Rect(50, 150, 75, 30), "Alright"))
        {
            showPopUp = false;
            // you may put other code to run according to your game too
        }

    }



    void Start()
    {
        open.onClick.AddListener(openpress);

        //string HtmlText = GetHtmlFromUri("https://upload.hubza.co.uk/i/connectiontest");
        //if (HtmlText == "")
        //{
        //    showPopUp = true;
        //}
        //else if (!HtmlText.Contains("success"))
        //{
        //
        //}
        //else
        //{
        //    string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //    string docPath = appdata + "\\trigen\\themes";
            getdropdownfiles();
        //    //Directory.Delete(docPath);
        //}

        
    }

    public void getdropdownfiles()
    {
        
        string url = "https://upload.hubza.co.uk/i/tgbuiltin0.1.zip";
        www = new WWW(url);

    }

    public void addfilestoarray()
    {
        themes.ClearOptions();
        themes.value = -1;
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string docPath = appdata + "\\trigen\\themes";

        string[] files = Directory.GetFiles(docPath, "*.tgt");
        //debug.text = "";
        foreach (string value in files)
        {
            int index = value.IndexOf('\\');
            toadd = value.Substring(value.LastIndexOf("\\") + 1);
            Debug.Log(toadd);
            //debug.text = debug.text + toadd + "\n";
            themes.options.Add(new Dropdown.OptionData() { text = toadd });
        }
    }

    

    // Update is called once per frame
    void Update() {

        

        if (www.isDone && !isUnzipped)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    
            Directory.CreateDirectory(appdata + "\\trigen\\themes");
    
            byte[] data = www.bytes;
    
            string docPath = appdata + "\\trigen\\themes\\test-themes.zip";
            docPath = appdata + "\\trigen\\themes\\test-themes.zip";
            Debug.Log("docPath=" + docPath);
            System.IO.File.WriteAllBytes(docPath, data);
    
            using (ZipInputStream s = new ZipInputStream(File.OpenRead(docPath)))
            {
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    Console.WriteLine(theEntry.Name);
    
                    string directoryName = appdata + "\\trigen\\themes\\" + Path.GetDirectoryName(theEntry.Name);
                    string fileName = appdata + "\\trigen\\themes\\" + Path.GetFileName(theEntry.Name);
    
                    // create directory
                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(directoryName);
                    }
    
                    if (fileName != String.Empty)
                    {
                        string filename = docPath.Substring(0, docPath.Length - 8);
                        filename = theEntry.Name;
                        Debug.Log("theEntry.Name: " + theEntry.Name);
                        Debug.Log("Unzipping: " + filename);
                        using (FileStream streamWriter = File.Create(fileName))
                        {
                            int size = 2048;
                            byte[] fdata = new byte[2048];
                            while (true)
                            {
                                size = s.Read(fdata, 0, fdata.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(fdata, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                isUnzipped = true;
                addfilestoarray();
            }
        }
    }

    public void openpress()
    {
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string docPath = appdata + "\\trigen\\themes";
        Application.OpenURL("file://" + docPath);
    }
}

