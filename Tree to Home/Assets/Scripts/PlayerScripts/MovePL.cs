using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePL : MonoBehaviour
{
    public float speed;
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator anim;
    public float jump;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
        if (movement >= 0.001f) {sr.flipX = false; anim.SetFloat("Run", Mathf.Abs(movement));}
        if (movement <= -0.001f) {sr.flipX = true; anim.SetFloat("Run", Mathf.Abs(movement)); }


        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
    }
}
