using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
using System.IO;

public class UIHideScript : MonoBehaviour
{
    public Button HideButton;
    public GameObject menu; // Assign in inspector
    private float isShowing;
    public GameObject tri;
    public GameObject _tri;
    public ReplaceTri _rTri;

    public UnityEngine.UI.Slider S_Spawnspeed;
    public UnityEngine.UI.Slider S_Speed;
    public UnityEngine.UI.Slider S_Opacity;
    public UnityEngine.UI.Slider S_Smin;
    public UnityEngine.UI.Slider S_Smax;

    public UnityEngine.UI.Slider S_CVRem;
    public UnityEngine.UI.Slider S_CVAdd;

    public InputField hextext;
    public InputField bghex;

    public Toggle seperate;

    public GameObject resetbgbutt;

    public Button resettributt;

    public Button delTriButton;

    public Button delallbutt;

    void Start()
    {
        _rTri = GameObject.Find("ReplaceTri").GetComponent<ReplaceTri>();
        HideButton.onClick.AddListener(HideButtonTap);
        delTriButton.onClick.AddListener(DelTri);
        resettributt.onClick.AddListener(ResetTriOptions);
        delallbutt.onClick.AddListener(delalltri);
        GetComponent<CanvasGroup>().interactable = true;



    }


    void Update()
    {
        if (Input.GetKeyDown("escape"))
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
    }
    void HideButtonTap()
    {
        if (GetComponent<CanvasGroup>().alpha == 1)
        {
            GetComponent<CanvasGroup>().alpha = 0;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = 1;
        }
    }
    public void DelTri()
    {
        GameObject[] tris;

        tris = GameObject.FindGameObjectsWithTag("Triangle");
        trivars.rotation = "up";
        foreach (GameObject aa in tris)
        {
            hextext.text = "ffffff";
            bghex.text = "ffffff";

            seperate.isOn = false;
            

            if(aa.name != "Tri") //Only Deletes Clones, so Tri's can be reset
            {
                Destroy(aa);
            }
            _rTri._triPrefab.GetComponent<SpriteRenderer>().sprite = _rTri._tri; //Sets prefab sprite to original
            _rTri._triPrefab.GetComponent<Triangle>().trianglespr = _rTri._tri; //^^

            S_Spawnspeed.value = trivars.orig_spawnspeed;
            S_Speed.value = trivars.orig_speed;
            S_Opacity.value = trivars.orig_opacity;
            S_Smin.value = trivars.orig_smin;
            S_Smax.value = trivars.orig_smax;
            S_CVRem.value = -trivars.orig_CVRem;
            S_CVAdd.value = trivars.orig_CVAdd;
        }
    }
    void ResetTriOptions()
    {
        trivars.rotation = "up";
        GameObject[] tris;

        tris = GameObject.FindGameObjectsWithTag("Triangle");

        foreach (GameObject aa in tris)
        {
            S_Spawnspeed.value = trivars.orig_spawnspeed;
            S_Speed.value = trivars.orig_speed;
            S_Opacity.value = trivars.orig_opacity;
            S_Smin.value = trivars.orig_smin;
            S_Smax.value = trivars.orig_smax;
        }
    }
    public void delalltri()
    {
        GameObject[] tris;
        GameObject[] UI;

        tris = GameObject.FindGameObjectsWithTag("Triangle");

        GameObject[] objs;
        objs = GameObject.FindGameObjectsWithTag("ColourUI");
        foreach (GameObject owo in objs)
        {
            owo.GetComponent<Image>().color = new Color(1, 0, 0, 1);
        }

        GameObject[] objs2;
        objs2 = GameObject.FindGameObjectsWithTag("ColourText");
        foreach (GameObject owo in objs2)
        {
            owo.GetComponent<Text>().color = new Color(1, 0, 0, 1);
        }

        foreach (GameObject aa in tris)
        {
            if (aa.name != "Tri") //Only Deletes Clones, so Tri's can be reset
            {
                Destroy(aa);
            }
        }
        }
}