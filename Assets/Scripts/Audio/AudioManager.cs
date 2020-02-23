using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SFB;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{

    public AudioSource _source; //Audio source refernce
    private string _audioLoc; //Audio file location string

    public Button stopwav; // but its a wav

    public void Start()
    {
        Debug.Log("start");
        stopwav.interactable = false;
        stopwav.onClick.AddListener(stopbutt);
    }

    public void LoadSound()
    {
        var extensions = new[] 
        {
            new ExtensionFilter("Sound Files", "wav", "mp3" ), //Sets file extentions
        };

        var paths = StandaloneFileBrowser.OpenFilePanel("Open Audio File", "", extensions, true); //Opens file browser with set extensions
        if(paths.Length == 1) //Checks to see if only 1 file selected
        {
            string loc = "file://" + paths[0]; //Changes the file path into a form that unity recognises
            _audioLoc = loc; //terrible way to make a string global, i cba redoing it. its late :) <3
            StartCoroutine(GetAudioClip()); //Starts co-routine to set audio
        }
    }

    IEnumerator GetAudioClip()
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(_audioLoc, AudioType.WAV)) //"Downloads" (unity be stupid), the audio file so we can create it _audioLoc is the file path
        {
            yield return www.SendWebRequest(); //Sends request to "Download"
            if (www.isNetworkError)
            {
                Debug.Log(www.error); //Error stuffs
            }
            else
            {
                _source.clip = DownloadHandlerAudioClip.GetContent(www); //Assings audio clip
                _source.Play(); //Plays Sounds
                stopwav.interactable = true;
            }
        }
    }

    public void stopbutt() //haha butt
    {
        Debug.Log("trying to stop");
        stopwav.interactable = false;
        _source.Stop();
    }
}
