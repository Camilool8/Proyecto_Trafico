using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour
{
    public bool KeepGoing;
    public GameObject TrafficState;
    public float speed= 2f;
    // Start is called before the first frame update
     void Start()
     {
        KeepGoing = false;
        transform.position = new Vector2(-11, -0.80f);
        transform.Rotate(0, 0,-90, Space.Self);
        TrafficState = GameObject.Find("S4");
     }

    // Update is called once per frame
    void Update()
    {
        if (TrafficState.GetComponent<Semaforo4>().S_2_4_V || KeepGoing)
        {
            transform.Translate(new Vector2(0, 2f) * speed * Time.deltaTime);
        }
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Stop")
        {
            KeepGoing = true;
        }
    }
    
}
