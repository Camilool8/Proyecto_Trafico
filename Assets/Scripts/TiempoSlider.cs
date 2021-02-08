using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoSlider : MonoBehaviour
{
    public float temporizador;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        temporizador = 1;
        slider.value = temporizador;
    }

    // Update is called once per frame
    public void TiempoSlide(float speed)
    {
        temporizador = speed;
    }
    
}
