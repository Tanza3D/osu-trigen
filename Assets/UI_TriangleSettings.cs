using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Global_Options;

public class UI_TriangleSettings : MonoBehaviour
{
    [SerializeField]
    [System.Serializable]
    public class SliderInputCombo
    {
        public Slider Slider;
        public InputField Field;

        public SliderInputCombo(Slider Slider, InputField Field)
        {
            this.Slider = Slider;
            this.Field = Field;
        }
    }

    [SerializeField]
    public SliderInputCombo Speed;
    public SliderInputCombo MinScale;
    public SliderInputCombo MaxScale;
    public SliderInputCombo SpeedMultiplier;

    void Start()
    {
        Speed.Slider.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeSpeed(Speed.Slider.value);
        });
        MinScale.Slider.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeMinScale(MinScale.Slider.value);
        });
        MaxScale.Slider.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeMaxScale(MaxScale.Slider.value);
        });
        SpeedMultiplier.Slider.onValueChanged.AddListener(delegate
        {
            Global_Options.Triangle.ChangeSpeedMultiplier(SpeedMultiplier.Slider.value);
        });
    }
}