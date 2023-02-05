using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raices : MonoBehaviour
{
    [SerializeField] ParticleSystem pS_Raiz;
    [SerializeField] REvents gameOver;
    
    void Start()
    {
        gameOver.GEvent += reproducir;
    }

  

    void reproducir()
    {
        pS_Raiz.Play();
    }
    private void OnDestroy()
    {
        gameOver.GEvent -= reproducir;
    }
}
