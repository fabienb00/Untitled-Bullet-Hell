using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPattern : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float constShotTimer; //This makes it so bullets are fired every shotTimer/60 seconds.
    private float shotTimer;

    private Quaternion shotRotation;
    private Quaternion inverseShotRotation;

    // Start is called before the first frame update
    void Start()
    {
        shotRotation = this.transform.rotation;
        inverseShotRotation = this.transform.rotation;
        inverseShotRotation.eulerAngles = -shotRotation.eulerAngles;
        shotTimer = constShotTimer;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (shotTimer != 0) shotTimer--;
        if (shotTimer == 0)
        {
            Instantiate(bulletPrefab, this.transform.position, shotRotation);
            Instantiate(bulletPrefab, this.transform.position, inverseShotRotation);
            addRotation(new Vector3(0, 60, 0));
            Instantiate(bulletPrefab, this.transform.position, shotRotation);
            Instantiate(bulletPrefab, this.transform.position, inverseShotRotation);
            addRotation(new Vector3(0, 60, 0));
            Instantiate(bulletPrefab, this.transform.position, shotRotation);
            Instantiate(bulletPrefab, this.transform.position, inverseShotRotation);
            addRotation(new Vector3(0, 60, 0));
            Instantiate(bulletPrefab, this.transform.position, shotRotation);
            Instantiate(bulletPrefab, this.transform.position, inverseShotRotation);
            addRotation(new Vector3(0, 60, 0));
            Instantiate(bulletPrefab, this.transform.position, shotRotation);
            Instantiate(bulletPrefab, this.transform.position, inverseShotRotation);
            addRotation(new Vector3(0, 60, 0));
            Instantiate(bulletPrefab, this.transform.position, shotRotation);
            Instantiate(bulletPrefab, this.transform.position, inverseShotRotation);
            addRotation(new Vector3(0, 60, 0));
            shotRotation = this.transform.rotation;
            shotTimer = constShotTimer;
        }
    }
    void addRotation(Vector3 add)
    {
        shotRotation.eulerAngles += add;
        inverseShotRotation.eulerAngles = -shotRotation.eulerAngles;
    }
}
