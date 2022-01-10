using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public SpriteRenderer sr;
    public Sprite[] imgs;
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDir;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            sr.sprite = imgs[0];
        if (Input.GetKey(KeyCode.LeftArrow))
            sr.sprite = imgs[1];
        if (Input.GetKey(KeyCode.UpArrow))
            sr.sprite = imgs[2];
        if (Input.GetKey(KeyCode.DownArrow))
            sr.sprite = imgs[3];
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            sr.sprite = imgs[4];
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            sr.sprite = imgs[5];
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            sr.sprite = imgs[6];
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
            sr.sprite = imgs[7];

        ProcessInputs();
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("ymen");
        float moveY = Input.GetAxisRaw("fo2");
        moveDir = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
