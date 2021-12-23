using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawner : MonoBehaviour
{
    public GameObject triangle;
    public List<GameObject> triangles;
    private void Start()
    {
        triangles = new List<GameObject>();
    }

    void Update()
    {
        while(this.transform.childCount < Global_Options.Spawner.Amount)
        {
            GameObject triangleT = Instantiate(triangle, this.transform);
            triangles.Add(triangleT);
        }
        while(this.transform.childCount > Global_Options.Spawner.Amount)
        {
            GameObject tToDest = triangles[0];
            triangles.Remove(tToDest);
            Destroy(tToDest.gameObject);
        }
        Global.topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
}
