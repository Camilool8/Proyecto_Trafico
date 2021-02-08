using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car4 : MonoBehaviour
{
    public bool KeepGoing;
    public GameObject TrafficState;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        KeepGoing = false;
        transform.position = new Vector2(1.3f, -7.68f);
        transform.Rotate(0, 0, 0, Space.Self);
        TrafficState = GameObject.Find("S3");
    }

    // Update is called once per frame
    void Update()
    {
        if (TrafficState.GetComponent<Semaforo3>().S_1_3_V || KeepGoing)
        {
            transform.Translate(new Vector2(0, 2f) * speed * Time.deltaTime);
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
