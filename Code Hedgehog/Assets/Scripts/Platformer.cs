﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float jumpForce;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;

    public float rememberGroundedFor;
    float lastTimeGrounded;

    public int defaultAdditionalJumps = 1;
    int additionalJumps;

    private bool moving = false;
    private Animator anim;
    public int countcollect = 0;

    public AudioSource Ezh;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        additionalJumps = defaultAdditionalJumps;
    }

    void Update()
    {
        Move();
        Jump();
        BetterJump();
        CheckIfGrounded();
    }


    void Move() {
        float x = Input.GetAxisRaw("Horizontal");

        float moveBy = x * speed;

        rb.velocity = new Vector2(moveBy, rb.velocity.y);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("Right", true);
            }
            else if (Input.GetKey(KeyCode.A)) anim.SetBool("Right", false);
            moving = true;
            anim.SetBool("Moving", moving);
        }
        else
        {
            moving = false;
            anim.SetBool("Moving", moving);
        }
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || Time.time - lastTimeGrounded <= rememberGroundedFor || additionalJumps > 0)) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            additionalJumps--;
        }
    }

    void BetterJump() {
        if (rb.velocity.y < 0) {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }   
    }

    void CheckIfGrounded() {
        Collider2D colliders = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);

        if (colliders != null) {
            isGrounded = true;
            additionalJumps = defaultAdditionalJumps;
        } else {
            if (isGrounded) {
                lastTimeGrounded = Time.time;
            }
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Collect1")
        {
            countcollect += 1;
            obj.gameObject.SetActive(false);
        }
    }

}
