using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D r2d;
    private Animator _animator;

    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            speed = 1.0f;
            Debug.Log("Hiz 1.0f");
        }
        else
        {
            speed = 0.0f;
            Debug.Log("Hiz 0.0f");
        }
        _animator.SetFloat("speed",speed);
        r2d.velocity = new Vector2(speed,0f);
    }
    
}
