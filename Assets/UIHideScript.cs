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

    public Button delTriButton;

    void Start()
    {
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
            Destroy(aa);
        }
    }
}