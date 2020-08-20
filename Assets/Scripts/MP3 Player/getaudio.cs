using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getaudio : MonoBehaviour
{
    public string url;
    public WWW www;
    public AudioSource audioSrc;
    public Button playbutt;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = playbutt.GetComponent<Button>();
        btn.onClick.AddListener(playbuttpress);
       
    }

    IEnumerator StartSong(string filename)
    {
        www = new WWW(filename);
        if (www.error != null)
        {
            Debug.Log(www.error);
        }
        else
        {
            audioSrc.clip = www.GetAudioClip();
            while (audioSrc.clip.loadState != AudioDataLoadState.Loaded)
                yield return new WaitForSeconds(0.1f);
            audioSrc.Play();
        }
    }
    void playbuttpress()
    {
        StartSong("file://C:/A.wav");
        Debug.Log("set");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
