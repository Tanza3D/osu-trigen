using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugOpener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("clickerinoes");
            if (GetComponent<CanvasGroup>().alpha == 1)
            {
                GetComponent<CanvasGroup>().alpha = 0;
            }
            else
            {
                GetComponent<CanvasGroup>().alpha = 1;
            }
        }
    }
}
