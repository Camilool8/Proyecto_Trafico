using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public Slider sli;
    public TiempoSlider slider;

    public void lento()
    {
        slider.temporizador = 0.2f;
        sli.value = slider.temporizador;
    }
    public void Normal()
    {
        slider.temporizador = 1;
        sli.value = slider.temporizador;
    }
    public void Rapido()
    {
        slider.temporizador = 4;
        sli.value = slider.temporizador;
    }


}
