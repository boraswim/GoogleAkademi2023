using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController2 : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float speed = 1.0f;
    private float moveDirection;

    private bool jump = false;
    private bool grounded = true;
    private Rigidbody2D _rigidBody2D;
    private SpriteRenderer _spriteRenderer;
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>(); // Caching animator
    }

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        _rigidBody2D.velocity = new Vector2(speed * moveDirection, _rigidBody2D.velocity.y);
        if(jump)
        {
            _rigidBody2D.velocity = new Vector2(_rigidBody2D.velocity.x, jumpForce);
            jump = false;
        }
    }

    private void Update()
    {
        if(grounded && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            if(Input.GetKey(KeyCode.A))
            {
                moveDirection = -1.0f;
                _spriteRenderer.flipX = true;
                anim.SetFloat("speed", speed);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                moveDirection = 1.0f;
                _spriteRenderer.flipX = false;
                anim.SetFloat("speed",speed);
            }
        }
        else if(grounded)
        {
            moveDirection = 0.0f;
            anim.SetFloat("speed",0.0f);
        }
        
        if(grounded && Input.GetKey(KeyCode.W))
        {
            jump = true;
            grounded = false;
            anim.SetTrigger("jump");
            anim.SetBool("grounded",false);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Zemin"))
            grounded = true;
            anim.SetBool("grounded",true);
    }

}
