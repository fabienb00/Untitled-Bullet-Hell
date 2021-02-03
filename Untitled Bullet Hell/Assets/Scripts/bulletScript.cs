using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed=100;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = speed*this.transform.forward;
    }
}
