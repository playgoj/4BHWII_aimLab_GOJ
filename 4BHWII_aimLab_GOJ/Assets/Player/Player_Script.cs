using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    public float speed;
    public float jumpHeight = 300;
    public float mouseXSpeed = 1;
    Rigidbody rigid;
    
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        float mouseXinput = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseXinput*mouseXSpeed, 0);

        transform.position += transform.forward * verticalInput * speed;
        transform.position += transform.right * horizontalInput * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpHeight);
        }
    }
}
