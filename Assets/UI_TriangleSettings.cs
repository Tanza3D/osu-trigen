using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Global_Options;

public class UI_TriangleSettings : MonoBehaviour
{
    public Slider Speed;
    public Slider MinScale;
    public Slider MaxScale;
    public Slider SpeedMultiplier;

    void Start()
    {
        Speed.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeSpeed(Speed.value);
        });
        MinScale.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeMinScale(MinScale.value);
        });
        MaxScale.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeMaxScale(MaxScale.value);
        });
        SpeedMultiplier.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeSpeedMultiplier(SpeedMultiplier.value);
        });
    }
}
