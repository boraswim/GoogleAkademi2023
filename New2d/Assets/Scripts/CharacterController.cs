using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float jumpForce = 500f;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private bool grounded;
    private bool started;
    private bool jumping;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        grounded = true;
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(started && grounded)
            {
                _animator.SetTrigger("jump");
                grounded = false;
                jumping = true;
            }
            else
            {
                _animator.SetBool("gameStarted", true);
                started = true;
            }
        }
        _animator.SetBool("grounded", grounded);
    }
    void FixedUpdate()
    {
        if(started)
            _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y);
        if(jumping)
        {
            _rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            jumping = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
            grounded = true;
    }

    
}
