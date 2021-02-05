using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    private int time = -1;

    private GameObject activate;

    private void FixedUpdate()
    {
        if (time != 0) time--;
        else if(time == 0)
        {
            activate.SetActive(true);
            time = -1;
        }
            
    }
    // Start is called before the first frame update
    public void beginCount(int time,GameObject activate)
    {
        this.time = time;
        this.activate = activate;
    }
}
