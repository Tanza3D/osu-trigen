using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SFB;
using UnityEngine.UI;

using NAudio;
using NAudio.Wave;
using System;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource _source; //Audio source refernce
    private string _audioLoc; //Audio file location string
    public Button playwav;
    public Button stopwav; // but its a wav
    public float updateStep = 0.1f;
    public int sampleDataLength = 1024;

    private float currentUpdateTime = 0f;

    private float clipLoudness;
    private float[] clipSampleData;

    public void Start()
    {
        Debug.Log("start");
        stopwav.interactable = false;
        playwav.onClick.AddListener(LoadSound);



        stopwav.onClick.AddListener(stopbutt);
    }

    public void LoadSound()
    {
        var extensions = new[] 
        {
            new ExtensionFilter("Sound Files", "wav", "ogg" ), //Sets file extentions
        };

        var paths = StandaloneFileBrowser.OpenFilePanel("Open Audio File", "", extensions, true); //Opens file browser with set extensions
        if(paths.Length == 1) //Checks to see if only 1 file selected
        {
            string loc = "file://" + paths[0]; //Changes the file path into a form that unity recognises
            _audioLoc = loc; //terrible way to make a string global, i cba redoing it. its late :) <3
            StartCoroutine(GetAudioClip()); //Starts co-routine to set audio
        }
        StartCoroutine(GetAudioClip());
    }

    public static void Mp3ToWav(string mp3File, string outputFile)
    {
        using (Mp3FileReader reader = new Mp3FileReader(mp3File))
        {
            using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
            {
                WaveFileWriter.CreateWaveFile(outputFile, pcmStream);
            }
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
                if (!audioSource)
                {
                    Debug.LogError(GetType() + ".Awake: there was no audioSource set.");
                }
                clipSampleData = new float[sampleDataLength];                stopwav.interactable = true;

            }
        }
    }

    public void stopbutt() //haha butt
    {
        Debug.Log("trying to stop");
        stopwav.interactable = false;
        _source.Stop();
    }




    public void Update()
    {
        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            try
            {
                audioSource.clip.GetData(clipSampleData, audioSource.timeSamples); //I read 1024 samples, which is about 80 ms on a 44khz stereo clip, beginning at the current sample position of the clip.
            }
            catch(Exception e)
            {
                Debug.Log("Try Failed: " + e);
            }

            clipLoudness = 0f;

            try
            {
                foreach (var sample in clipSampleData)
                {
                    clipLoudness += Mathf.Abs(sample);
                }
                clipLoudness /= sampleDataLength; //clipLoudness is what you are looking for
                trivars.songvol = 1.2f * (1 + clipLoudness * 5);
                Debug.Log("aftercalc: " + trivars.songvol);
            }
            catch
            {

            }

        }





    }


}
