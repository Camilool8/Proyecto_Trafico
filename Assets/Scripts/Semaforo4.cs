using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo4 : MonoBehaviour
{
    public GameObject semaforo2_4_V;
    public GameObject semaforo2_4_A;
    public GameObject semaforo2_4_R;
    public bool S_2_4_V;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLights());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Semaforo2_4_V()
    {
        S_2_4_V = true;
        semaforo2_4_V.SetActive(true);
        semaforo2_4_A.SetActive(false);
        semaforo2_4_R.SetActive(false);
    }
    void Semaforo2_4_A()
    {
        S_2_4_V = true;
        semaforo2_4_V.SetActive(false);
        semaforo2_4_A.SetActive(true);
        semaforo2_4_R.SetActive(false);
    }
    void Semaforo2_4_R()
    {
        S_2_4_V = false;
        semaforo2_4_V.SetActive(false);
        semaforo2_4_A.SetActive(false);
        semaforo2_4_R.SetActive(true);
    }

    IEnumerator TrafficLights()
    {
        while (true)
        {
            Semaforo2_4_R();
            yield return new WaitForSeconds(5);
            Semaforo2_4_V();
            yield return new WaitForSeconds(3);
            Semaforo2_4_A();
            yield return new WaitForSeconds(1);

        }


    }


}
