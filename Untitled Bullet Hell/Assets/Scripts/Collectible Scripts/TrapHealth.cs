using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapHealth : TrapBase
{
    public int changeHealthAmount; //This is a number that can go from a negative to a positive, allowing this one code to deal with both damaging and healing traps

    protected override void pickup(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().changeHealth(changeHealthAmount);
            TrapVFXSFXScript temp = this.gameObject.GetComponentInParent<TrapVFXSFXScript>();
            Debug.Log(temp);
            if (temp != null) temp.playFX();
            base.pickup(other);
        }
    }
}
