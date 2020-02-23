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

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.S))
        {
            _saveDialog.SavePressed();
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.O))
        {
            _saveDialog.LoadPressed();
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.T))
        {
            _replaceTri.LoadTri();
        }
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.T))
        {
            _resetTri.ResetTria();
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.B))
        {
            _replaceBG.LoadBG();
        }
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.B))
        {
            _replaceBG.ResetBG();
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W))
        {
            _audioManager.LoadSound();
        }
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.W))
        {
            _audioManager.stopbutt();
        }
    }
}
