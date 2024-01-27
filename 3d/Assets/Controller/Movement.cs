using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody capsule;
    public Vector2 moveVal;
    public float moveSpeed = 10;

    private void Awake()
    {
        capsule = GetComponent<Rigidbody>();
    }

    public void Moving(InputAction.CallbackContext value)
    {
        if(value.performed)
        {
            moveVal = value.ReadValue<Vector2>();
            /*
            Debug.Log("Performed");
            Debug.Log(moveVal.x + " " + moveVal.y);
            capsule.AddForce(new Vector3(moveVal.x * moveSpeed, 0, moveVal.y * moveSpeed), ForceMode.Impulse);
            */
        }

        if(value.canceled)
        {
            moveVal = value.ReadValue<Vector2>();
        }
    }
}
