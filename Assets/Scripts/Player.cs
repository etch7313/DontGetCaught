using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public SpriteRenderer sr;
    public Sprite[] imgs;
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDir;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            sr.sprite = imgs[0];
        if (Input.GetKey(KeyCode.A))
            sr.sprite = imgs[1];
        if (Input.GetKey(KeyCode.W))
            sr.sprite = imgs[2];
        if (Input.GetKey(KeyCode.S))
            sr.sprite = imgs[3];
        if(Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.D))
            sr.sprite = imgs[4];
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            sr.sprite = imgs[5];
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            sr.sprite = imgs[6];
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            sr.sprite = imgs[7];

        ProcessInputs();
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDir = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
