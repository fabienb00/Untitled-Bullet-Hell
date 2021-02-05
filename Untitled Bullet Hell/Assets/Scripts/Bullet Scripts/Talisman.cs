using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bullet;

public class Talisman : Bullet
{
    private int damage = -5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyPatternHandler>().changeHealth(damage);
            GameObject.Destroy(this.gameObject);
        }
    }
}
