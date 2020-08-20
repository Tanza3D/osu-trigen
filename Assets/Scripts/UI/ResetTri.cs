using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTri : MonoBehaviour
{
    public GameObject _tri;
    public ReplaceTri _rTri;
    public Button resettributt;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _rTri = GameObject.Find("ReplaceTri").GetComponent<ReplaceTri>();
        resettributt.onClick.AddListener(ResetTria);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetTria()
    {
        GameObject[] tris;

        tris = GameObject.FindGameObjectsWithTag("Triangle");
        foreach (GameObject aa in tris)
        {
            _rTri._triPrefab.GetComponent<SpriteRenderer>().sprite = _rTri._tri; //Sets prefab sprite to original
            _rTri._triPrefab.GetComponent<Triangle>().trianglespr = _rTri._tri; //^^
        }
    }
}
