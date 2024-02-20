using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    private int health = 3;
    [SerializeField] private GameObject[] _healthUI;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private GameObject _fadePanel;

void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            health--;
            if(health >= 0) _healthUI[health].gameObject.SetActive(false);
            if(health == 0)
            {
                _gameOver.SetActive(true);
                _fadePanel.SetActive(true);
                StartCoroutine("fade");
            }
        }

        if(other.gameObject.CompareTag("UI"))
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("UI"))
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        } 
    }

    IEnumerator fade()
{
    yield return new WaitForSeconds(1.1f);
    Time.timeScale = 0f;
}
}


