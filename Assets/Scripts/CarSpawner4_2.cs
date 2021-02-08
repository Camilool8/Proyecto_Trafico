using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner4_2 : MonoBehaviour
{
    public float random;
    public GameObject[] Car1;
    public GameObject[] Car2;
    public GameObject[] Car3;
    public GameObject[] Car4;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GenerarCarro4_2", 1, 6);
        InvokeRepeating("GenerarCarro1_3", 1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void GenerarCarro4_2()
    {
        
        Instantiate(Car1[0], transform.position, Quaternion.identity);
        Instantiate(Car2[0], transform.position, Quaternion.identity);

    }

    void GenerarCarro1_3()
    {
        Instantiate(Car3[0], transform.position, Quaternion.identity);
        Instantiate(Car4[0], transform.position, Quaternion.identity);
}
}
