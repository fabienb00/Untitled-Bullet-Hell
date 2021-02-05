using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pattern : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float constShotTimer; //This makes it so bullets are fired every shotTimer/60 seconds.
    protected float shotTimer;

    protected Quaternion shotRotation;


    // Start is called before the first frame update
    protected void Start()
    {
        shotRotation = this.transform.rotation;
        shotTimer = constShotTimer;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void FixedUpdate()
    {
    }
    public abstract void shoot();
}

