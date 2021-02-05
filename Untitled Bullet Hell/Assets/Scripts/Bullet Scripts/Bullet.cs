using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 100;
    public int damage = 25;

    public Rigidbody rb;

    // Start is called before the first frame update
    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    protected void Update()
    {
        rb.velocity = speed * this.transform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().changeHealth(-damage);
            GameObject.Destroy(this.gameObject);
        }
    }
}
