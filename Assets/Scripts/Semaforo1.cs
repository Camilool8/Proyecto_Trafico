using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo1 : MonoBehaviour
{
    public GameObject semaforo1_3_V;
    public GameObject semaforo1_3_A;
    public GameObject semaforo1_3_R;
    public bool S_1_3_V;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLights());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Semaforo1_3_V()
    {
        S_1_3_V = true;
        semaforo1_3_V.SetActive(true);
        semaforo1_3_A.SetActive(false);
        semaforo1_3_R.SetActive(false);
    }
    void Semaforo1_3_A()
    {
        S_1_3_V = true;
        semaforo1_3_V.SetActive(false);
        semaforo1_3_A.SetActive(true);
        semaforo1_3_R.SetActive(false);
    }
    void Semaforo1_3_R()
    {
        S_1_3_V = false;
        semaforo1_3_V.SetActive(false);
        semaforo1_3_A.SetActive(false);
        semaforo1_3_R.SetActive(true);
    }

    IEnumerator TrafficLights()
    {
        while (true)
        {
            Semaforo1_3_V();
            yield return new WaitForSeconds(3);
            Semaforo1_3_A();
            yield return new WaitForSeconds(2);
            Semaforo1_3_R();
            yield return new WaitForSeconds(4);

        }

        
    }

    
}
