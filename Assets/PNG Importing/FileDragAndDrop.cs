using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using B83.Win32;
using System.Collections;
using UnityEngine.UI;
using System.IO;


public class FileDragAndDrop : MonoBehaviour
{
    [SerializeField] private Sprite triMat; // SET ME IN SPECTOR TO THE TRIANGLE MATERIAL
    // important to keep the instance alive while the hook is active.
    UnityDragAndDropHook hook;
    public GameObject tri;
    void OnEnable()
    {
        // must be created on the main thread to get the right thread id.
        hook = new UnityDragAndDropHook();
        hook.InstallHook();
        hook.OnDroppedFiles += OnFiles;
    }
    void OnDisable()
    {
        hook.UninstallHook();
    }

    void OnFiles(List<string> aFiles, POINT aPos)
    {
        // do something with the dropped file names. aPos will contain the 
        // mouse position within the window where the files has been dropped.
        Debug.Log("Dropped " + aFiles.Count + " files at: " + aPos + "\n" +
            aFiles.Aggregate((a, b) => a + "\n" + b));
        //image.sprite = Resources.Load(aPos) as Sprite;
        if (aFiles.Count == 0)
        {
            return;
        }
        string filePath = aFiles[0];
        Texture2D tex = null;
        byte[] fileData;
        fileData = File.ReadAllBytes(filePath);
        tex = new Texture2D(2, 2);
        tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        Rect rec = new Rect(0, 0, 1024, 1024);
        tri.GetComponent<SpriteRenderer>().sprite = Sprite.Create(tex, rec, new Vector2(0.5f, 0.5f), 100);
        
    }

    void Update()
    {
       //if (Input.GetKeyDown(KeyCode.K))
       //{
       //    string filePath = "C:\\Users\\hubst\\Documents\\swirl.png";
       //    Texture2D tex = null;
       //    byte[] fileData;
       //    fileData = File.ReadAllBytes(filePath);
       //    tex = new Texture2D(2, 2);
       //    tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
       //
       //    Sprite[] array = Resources.LoadAll<Sprite>(filePath);
       //
       //    Rect rec = new Rect(0, 0, 1024, 1024);
       //    tri.GetComponent<SpriteRenderer>().sprite = Sprite.Create(tex, rec, new Vector2(0.5f, 0.5f), 100);
       // 
       //}
    }
}