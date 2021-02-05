using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{
    //This script will allow a gameObject to chase the player up to a certain range.

    //Define references to important objects and components
    private GameObject player;
    private Rigidbody rb;

    [SerializeField] private float range = 25; //The range until which the gameObject chases the player. default value 25;
    [SerializeField] private float speed = 0.15f;    //The speed at which the object moves towards the player.

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        //This script requires the GameObject to have a kinematic rigidbody.
        if(Vector3.Distance(player.transform.position,rb.transform.position) >= range)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(rb.transform.position, player.transform.position, step);
        }
    }
}
