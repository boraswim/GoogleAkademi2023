using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{
    [SerializeField] private GameObject _camera;

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(transform.position,new Quaternion(transform.rotation.x, _camera.transform.rotation.y, transform.rotation.z, transform.rotation.w));
    }
}
