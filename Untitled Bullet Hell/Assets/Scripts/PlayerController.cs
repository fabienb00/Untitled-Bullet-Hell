using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float moveSpeed = 30f;

    private const float focusedMoveSpeed= 10f;
    private const float unfocusedMoveSpeed= 30f;

    //In this section I define keybinds.
    public string focusButton = "left shift"; //string value of the key that must be pressed to focus.
    public KeyCode shotButton = KeyCode.Mouse0; //string value of the key that must be held to shoot.
    public KeyCode bombButton = KeyCode.Mouse1; //string value of the key that must be pressed to bomb.

    public Rigidbody rb;

    public GameObject talismanPrefab;

    public float constShotTimer=10f; //This makes it so bullets are fired every shotTimer/60 seconds.
    private float shotTimer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        shotTimer = constShotTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(focusButton)) moveSpeed = focusedMoveSpeed;
        else if (Input.GetKeyUp(focusButton)) moveSpeed = unfocusedMoveSpeed;

        //rb.MovePosition(transform.position + ((transform.forward*moveSpeed*Input.GetAxis("Forward")) + Vector3.up*moveSpeed*Input.GetAxis("Upwards") + transform.right*moveSpeed*Input.GetAxis("Sideways"))*Time.deltaTime);
        rb.velocity = ((transform.forward * moveSpeed * Input.GetAxis("Forward")) + Vector3.up * moveSpeed * Input.GetAxis("Upwards") + transform.right * moveSpeed * Input.GetAxis("Sideways"));

        if (Input.GetKey(KeyCode.Mouse0) && shotTimer == 0)
        {
            shootBullet();
        }

    }

    private void FixedUpdate()
    {
        if (shotTimer != 0) shotTimer--;
    }

    private void shootBullet()
    {
        //These two shoot the right bullets
        Instantiate(talismanPrefab, (transform.position + transform.forward * 1 - transform.up * 1 + transform.right * 0.5f), this.transform.rotation);
        //These two shoot the left bullets
        Instantiate(talismanPrefab, (transform.position + transform.forward * 1 - transform.up * 1 - transform.right * 0.5f), this.transform.rotation);

        shotTimer = constShotTimer;
    }
}
