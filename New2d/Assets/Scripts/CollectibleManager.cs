using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] AudioClip clickSound;
    int count = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            Debug.Log(count);
            count++;
            AudioSource.PlayClipAtPoint(clickSound, other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
