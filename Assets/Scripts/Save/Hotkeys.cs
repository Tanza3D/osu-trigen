using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotkeys : MonoBehaviour
{
    public SaveDialog _saveDialog;
    public ReplaceTri _replaceTri;
    public ResetTri _resetTri;
    public ReplaceBG _replaceBG;
    public AudioManager _audioManager;
    public PopupControl _popup;
    public UIHideScript _uihide;

    // https://upload.hubza.co.uk/i/trigenhotkeys
    private void Update()
    {
        // Save
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.S))
        {
            _saveDialog.SavePressed();
        }
        // Load
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.O))
        {
            _saveDialog.LoadPressed();
        }
        // ReplaceTri
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.T))
        {
            _replaceTri.LoadTri();
        }
        // ResetTri
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.T))
        {
            _resetTri.ResetTria();
        }
        // LoadBG
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.B))
        {
            _replaceBG.LoadBG();
        }
        // ResetBG
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.B))
        {
            _replaceBG.ResetBG();
        }
        // PlayWAV
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W))
        {
            _audioManager.LoadSound();
        }
        // StopWAV
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.W))
        {
            _audioManager.stopbutt();
        }

        //Reset Tri Options
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.O))
        {
            _uihide.DelTri();
        }

        //OpenWebsite
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.O))
        {
            _popup.webpress();
        }
        //SourceCode
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.E))
        {
            _popup.sourcepress();
        }
        //PrivacyPolicy
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.C))
        {
            _popup.privacypress();
        }
        //Credits
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.H))
        {
            _popup.credpress();
        }
        //ReportBug
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.R))
        {
            _popup.reportpress();
        }

        //Language
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.L))
        {

        }
    }
}
