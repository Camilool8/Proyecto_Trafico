using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        SliderValue();
    }

    public void SliderValue()
    {
        Time.timeScale = slider.value;
    }
}
