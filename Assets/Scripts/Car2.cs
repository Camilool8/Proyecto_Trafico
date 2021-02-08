using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public bool KeepGoing;
    public GameObject TrafficState;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        KeepGoing = false;
        transform.position = new Vector2(10.66f, 0.70f);
        transform.Rotate(0, 0, 90, Space.Self);
        TrafficState = GameObject.Find("S2");
    }

    // Update is called once per frame
    void Update()
    {
        if (TrafficState.GetComponent<Semaforo2>().S_1_3_V || KeepGoing)
        {
            transform.Translate(new Vector2(0, 1f) * speed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Stop")
        {
            KeepGoing = true;
        }
    }

}
