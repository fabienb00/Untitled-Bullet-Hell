using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseXSensitivity = 1f;
    public float mouseYSensitivity = 1f;

    float xAccumulator; // this is a member variable, NOT a local!
    float yAccumulator;

    const float Snappiness = 10.0f; // larger values of this cause less filtering, more responsiveness

    float inputX;
    float inputY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Mouse X");
        //inputY = Input.GetAxis("Mouse Y");

        xAccumulator = Mathf.Lerp(xAccumulator, inputX, Snappiness * Time.deltaTime);
        //yAccumulator = Mathf.Lerp(yAccumulator, inputY, Snappiness * Time.deltaTime);

        
        float mouseX = mouseXSensitivity * xAccumulator * Time.deltaTime;
        //float mouseY = mouseYSensitivity * yAccumulator * Time.deltaTime;
        gameObject.transform.Rotate(0, mouseX, 0, Space.World);

    }
}
