using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3 : MonoBehaviour
{
    public bool KeepGoing;
    public GameObject TrafficState;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        KeepGoing = false;
        transform.position = new Vector2(-1.14f, 7.83f);
        transform.Rotate(0, 0, -180);
        TrafficState = GameObject.Find("S1");

    }

    // Update is called once per frame
    void Update()
    {
        if (TrafficState.GetComponent<Semaforo1>().S_1_3_V || KeepGoing)
        {
            transform.Translate(new Vector2(0, 1f) * speed * Time.deltaTime);
        }
            
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Stop")
        {
            KeepGoing = true;
        }
    }

}
