using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerStart : MonoBehaviour
{
    private PlayableDirector _pDirector;
    void Start()
    {
        _pDirector = GetComponent<PlayableDirector>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("playCutscene");
        }
    }

    IEnumerator playCutscene()
    {
        _pDirector.Play();
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }
}
