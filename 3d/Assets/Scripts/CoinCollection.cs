using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using CoinRand;
using System;
using TMPro;
public class CoinCollection : MonoBehaviour
{
    private CoinInst randomizer;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private TMP_Text _text;
    private int count;
    private AudioSource click;
    private int totalSpawnPoints;
    int y;
    private void Start()
    {
        click = GetComponent<AudioSource>();
        randomizer = _gameObject.GetComponent(typeof(CoinInst)) as CoinInst;
        totalSpawnPoints = randomizer.spawnPoints.Count();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            count++;
            _text.text = count.ToString();
            other.gameObject.SetActive(false);
            click.Play();
            StartCoroutine(Spawn(other.gameObject));
        }
    }

    IEnumerator Spawn(GameObject gameObject)
    {
        // 3 saniye sonra active state dönecek
        int x = randomizer.spawnPoints.IndexOf(gameObject.transform.parent.transform);
        randomizer.randomValues.Remove(x);

        yield return new WaitForSeconds(3);
        while(randomizer.randomValues.Count < Math.Ceiling(totalSpawnPoints / 2.0f))
        {
            y = randomizer.r.Next(0,randomizer.spawnPoints.Count() - 1);
            randomizer.randomValues.Add(y);
        }
        gameObject.transform.position = randomizer.spawnPoints[y].transform.position;
        gameObject.SetActive(true);
    }
}
