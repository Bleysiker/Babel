using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killtheseed : MonoBehaviour
{
    [SerializeField] Animator animatorS;
    [SerializeField] REvents gameOver;
    void Start()
    {
        gameOver.GEvent += Dead;
    }

    void Dead()
    {
        animatorS.SetBool("Dead", true);
    }
    private void OnDestroy()
    {
        gameOver.GEvent -= Dead;
    }
}
