using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float jumpForce;
    public float jumpSpeed;

    Animator animacion;
    Rigidbody2D rb;
    
    void Start()
    {
        jumpForce = 5;
        animacion = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, -180);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        float move = Input.GetAxis("Horizontal");
        bool walking = move != 0 ? true : false;

        animacion.SetBool("Walking", walking);
    }
}
