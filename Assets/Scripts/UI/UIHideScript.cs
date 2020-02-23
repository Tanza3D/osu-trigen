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
    private bool isShowing;
    public GameObject tri;
    public GameObject _tri;
    public ReplaceTri _rTri;

    public UnityEngine.UI.Slider S_Spawnspeed;
    public UnityEngine.UI.Slider S_Speed;
    public UnityEngine.UI.Slider S_Opacity;
    public UnityEngine.UI.Slider S_Smin;
    public UnityEngine.UI.Slider S_Smax;

    public UnityEngine.UI.Text hextext;

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

        
    }


    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }
    void HideButtonTap()
    {
        isShowing = !isShowing;
        menu.SetActive(isShowing);
    }
    void DelTri()
    {
        GameObject[] tris;

        tris = GameObject.FindGameObjectsWithTag("Triangle");

        foreach (GameObject aa in tris)
        {
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
        }
    }
    void ResetTriOptions()
    {
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

        tris = GameObject.FindGameObjectsWithTag("Triangle");

        foreach (GameObject aa in tris)
        {
            if (aa.name != "Tri") //Only Deletes Clones, so Tri's can be reset
            {
                Destroy(aa);
            }
        }
        }
}