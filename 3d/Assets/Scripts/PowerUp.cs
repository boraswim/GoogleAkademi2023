using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using MusicFilesNM;

public class PowerUp : MonoBehaviour
{
    private GameObject _music;
    private MusicFiles _musicFiles;
    ThirdPersonController _thirdPersonController;
    [SerializeField] private int Number;
    [SerializeField] private GameObject powerUp;
    void Start()
    {
        _music = GameObject.Find("AudioManager");
        _musicFiles = _music.GetComponent(typeof(MusicFiles)) as MusicFiles;
        _thirdPersonController = GetComponent<ThirdPersonController>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Power Up"))
        {
            powerUp.SetActive(true);
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(_musicFiles.music[Number], gameObject.transform.position);
            _thirdPersonController.SprintSpeed = 10.0f;
            Invoke("BackToNormalSpeed", 3.0f);
        }
    }

    private void BackToNormalSpeed()
    {
        powerUp.SetActive(false);
        _thirdPersonController.SprintSpeed = 5.33f;
    }
}
