using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public GameObject TriPrefab;
    public float YSpeedMin;
    public float YSpeedMax;
    public float OpacityMin;
    public float OpacityMax;
    public float ScaleMin;
    public float ScaleMax;
    public float FinalSpeed;
    public float FinalScale;
    public float FinalOpacity;
    public float StartX;
    public float StartY;
    void Start()
    {
        SpriteRenderer spRend = transform.GetComponent<SpriteRenderer>();
        Color col = spRend.color;
        FinalOpacity = Random.Range(OpacityMin, OpacityMax);
        col.a = FinalOpacity;
        spRend.color = col;
        StartX = Random.Range(-10.1f, 10.1f); //Gets X for spawn
        StartY = -8 ; //Sets startY to just off screen
        FinalScale = Random.Range(ScaleMin, ScaleMax); //Sets FinalScale to a random number between ScaleMin and ScaleMax
        FinalSpeed = Random.Range(YSpeedMin, YSpeedMax); //Sets FinalSpeed to a random number between YSpeedMin and YSpeedMax
        transform.position = new Vector3(StartX,StartY,0); //Sets the position to StartX and StartY, sets Z to 0
        transform.localScale = new Vector3(FinalScale, FinalScale, 1); //Sets the scale to FinalScale
    }
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * FinalSpeed; //Moves up at speed of FinalSpeed
        if (transform.position.y >= 20) { 
            print("uwu");
            Destroy(gameObject);
        }
    }
}