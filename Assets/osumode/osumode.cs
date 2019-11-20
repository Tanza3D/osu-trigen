using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class osumode : MonoBehaviour
{

    public AudioClip circles;
    public AudioClip welcome;
    public AudioSource player;
    public Text topheader;
    public Text bottomheader;
    public string topheadersave;
    public string bottomheadersave;
    public Slider opacityslider;

    public Button OMButton;

    // Start is called before the first frame update
    void Start()
    {
        osumodecontroller.omode = 0;
        OMButton.onClick.AddListener(OMButtonClick);
    }

    // Update is called once per frame
    void OMButtonClick()
    {
        if (osumodecontroller.omode == 0)
        {
            osumodecontroller.omode = 1;
            player.PlayOneShot(circles, 1F);
            player.PlayOneShot(welcome, 1F);
            GameObject[] tris;

            bottomheadersave = bottomheader.text;
            topheadersave = topheader.text;

            bottomheader.text = "to the beat!";
            topheader.text = "click circles!";

            opacityslider.value = 1f;

            tris = GameObject.FindGameObjectsWithTag("Triangle");

            foreach (GameObject aa in tris)
            {
                Destroy(aa);
            }
        }
        else
        {
            osumodecontroller.omode = 0;
            player.Stop();
            GameObject[] tris;

            topheader.text = topheadersave;
            bottomheader.text = bottomheadersave;

            opacityslider.value = 0.1f;

            tris = GameObject.FindGameObjectsWithTag("Triangle");

            foreach (GameObject aa in tris)
            {
                Destroy(aa);
            }
        }
    }
}
