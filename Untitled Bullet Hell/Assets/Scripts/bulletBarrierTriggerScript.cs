using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBarrierTriggerScript : MonoBehaviour
{
    private BoxCollider bc;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Bullet") Destroy(other.gameObject);
    }
}
