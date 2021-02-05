using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupBase : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        pickup(other);
    }

    // The plan is to only ever change the behaviour of the pickup method in more specific implementations.
    abstract protected void pickup(Collider other);
}
