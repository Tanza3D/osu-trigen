using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
using System.IO;

public class AudioDialog : MonoBehaviour
{
    public Button LoadButton;
    private string _data = "";
    public Text output;
    public string path;
    public AudioClip song;
    public UnityEngine.WWW www;
    public string url;


    public AudioSource source;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator StartSong(string path)
    {
        www = new WWW(path);
        source.clip = www.GetAudioClip();
        while (source.clip.loadState != AudioDataLoadState.Loaded)
            yield return new WaitForSeconds(0.1f);
        source.Play();
    }

    void LoadPressed()
    {
        //var paths = StandaloneFileBrowser.OpenFilePanel("Load audio file (.mp3)", "", "mp3", false);
        //if (paths.Length > 0)
        //{
        //   string url = "file:////" + paths[0];
        //   song = (AudioClip)Resources.Load(url, typeof(AudioClip));
        //   print(song);
        //    
        //}
        path = "C:\\users\\hubst\\Downloads\\DJ Stuiter - Steephouse (v1).wav";
        song = Resources.Load<AudioClip>(path);
        print(path);
        source.PlayOneShot(song);
        StartSong(path);
    }

    void Start()
    {
        LoadButton.onClick.AddListener(LoadPressed);
    }




}
