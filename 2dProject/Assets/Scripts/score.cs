using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    /*
    public static score instance;
    void Awake()
    {
        if(instance==null)
            instance = this;
        else   
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    */
    public static int totalScore = 0;
    public static int lives = 3;
}
