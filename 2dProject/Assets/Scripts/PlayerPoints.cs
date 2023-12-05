using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int score = 0;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Elmas"))
        {
            _audio.Play();
            Destroy(other.gameObject);
            score++;
        }
    }
}
