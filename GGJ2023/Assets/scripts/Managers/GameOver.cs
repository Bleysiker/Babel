using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] REvents gameOver;
    [SerializeField] bool perdio;
    private void Start()
    {
        gameOver.GEvent += Perder;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") & perdio ==false)
        {
            gameOver.FireEvent();
        }
    }
    void Perder()
    {
        perdio = true;
    }
    private void OnDestroy()
    {
        gameOver.GEvent -= Perder;
    }
}
