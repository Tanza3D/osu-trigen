using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using B83.Win32;
using System.Collections;
using UnityEngine.UI;
using System.IO;

// !!!

// would enjoy a button to do this too if you can

// !!!


public class FileDragAndDrop : MonoBehaviour
{
    [SerializeField] private Sprite triMat; // SET ME IN SPECTOR TO THE TRIANGLE MATERIAL
    // important to keep the instance alive while the hook is active.
    UnityDragAndDropHook hook; // makes a hook ?
    public GameObject tri; // adds gameobject called tri 
    void OnEnable() // lets go
    {
        // must be created on the main thread to get the right thread id.
        hook = new UnityDragAndDropHook();    // no clue
        hook.InstallHook();                   // no clue
        hook.OnDroppedFiles += OnFiles;       // no clue
    }
    void OnDisable() // kbye
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
      
            string filePath = aFiles[0]; // sets filepath to the first file dragged(?)
            Texture2D tex = null; // makes texture
            byte[] fileData; // makes a byte called filedata
            fileData = File.ReadAllBytes(filePath); // reads the bytes of the file
            tex = new Texture2D(2, 2); // make new texture, dunno what the 2, 2 is 
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            Rect rec = new Rect(0, 0, 1024, 1024); // put texture on 1024x1024 cube (needs to be updated to png size of triangle, if im correct it changed
            tri.GetComponent<SpriteRenderer>().sprite = Sprite.Create(tex, rec, new Vector2(0.5f, 0.5f), 100); // sets the sprite to the square i think?
        
        
    }

    void Update()
    {
       // this was to test the sprite importing without having to build
       //if (Input.GetKeyDown(KeyCode.K))
       //{
       //    string filePath = "C:\\Users\\hubst\\Documents\\swirl.png"; //probably need to set this to a path existant on your pc
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