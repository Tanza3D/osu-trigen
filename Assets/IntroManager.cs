using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{

    private double waittime;
    private double trispawnerwaittime;
    public float SpawnSpeedFinal;
    //public scene trigenmain;

    // Start is called before the first frame update
    void Start()
    {
        waittime = 0;
        trispawnerwaittime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        waittime += 1;
        trispawnerwaittime += 1;
        if (waittime == 520)
        {
            print("Intro Ended, Changing Scene");
            SceneManager.LoadScene("osu!trigen");

        }
        //if (trispawnerwaittime >= 240)
        //{
        //    GameObject go = Instantiate(triangle, new Vector3(0, 0, 0), Quaternion.identity);
        //}
        if (Input.GetKeyDown("escape"))
        {
            print("User Inturrupted, Changing Scene");
            SceneManager.LoadScene("osu!trigen");
        }
    }
}
