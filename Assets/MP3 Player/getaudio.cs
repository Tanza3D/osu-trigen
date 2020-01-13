using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaudio : MonoBehaviour
{
    public string url;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        WWW www = new WWW("file://////C://A.wav");
        source = GetComponent<AudioSource>();
        source.clip = www.GetAudioClip();
        source.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
