using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBase : PickupBase
{
    public int resetTimeConfig = 60; //This makes it so a trap, by default, resets every 600 frames, or 10 seconds.

    public Activator activator;

    //The default behaviour for all Traps is to reset after a time.
    override protected void pickup(Collider other)
    {
        this.gameObject.SetActive(false);
        activator.beginCount(resetTimeConfig,this.gameObject);
    }
}
