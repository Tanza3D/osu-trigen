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

    public Button delTriButton;

    void Start()
    {
        _rTri = GameObject.Find("ReplaceTri").GetComponent<ReplaceTri>();
        HideButton.onClick.AddListener(HideButtonTap);
        delTriButton.onClick.AddListener(DelTri);
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
        }
    }
}