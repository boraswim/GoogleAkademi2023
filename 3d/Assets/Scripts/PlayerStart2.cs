using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerStart2 : MonoBehaviour
{
    [SerializeField] private PlayableDirector _pDirector;

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
