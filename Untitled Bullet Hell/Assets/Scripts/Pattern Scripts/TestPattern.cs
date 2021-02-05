using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Pattern;

public class TestPattern : Pattern
{
    private Quaternion inverseShotRotation;

    // Start is called before the first frame update
    protected new void Start()
    {
        base.Start();
        inverseShotRotation = this.transform.rotation;
        inverseShotRotation.eulerAngles = -shotRotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
    }

    override public void shoot()
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
