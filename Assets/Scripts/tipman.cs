using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;


public class tipman : MonoBehaviour
{
    public Animation animator;
    
    public Button closebutt;
    public CanvasGroup uipanel;

    public bool buttpressed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playAnimation());
        closebutt.onClick.AddListener(hideslide);
    }

    void hideslide()
    {
        animator.Play();
        buttpressed = true;
    }
    public IEnumerator playAnimation()
    {
        yield return new WaitForSeconds(20f);
        if (buttpressed == false)
        {
            animator.Play();
        }
    }

}
