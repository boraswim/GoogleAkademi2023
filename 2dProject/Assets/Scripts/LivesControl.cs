using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LivesControl : MonoBehaviour
{
    private void Awake()
    {
        switch(score.lives)
        {
            case 0:
                SceneManager.LoadScene(3);
                break;

            case 1:
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 2:
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 3:
                break;
            default:
                break;
        }
    }
}
