using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartObstacle : MonoBehaviour
{
    [SerializeField] REvents restart1, restart2, restart3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obs1"))
        {
            restart1.FireEvent();
        }
        if (collision.CompareTag("Obs2"))
        {
            restart2.FireEvent();
        }
        if (collision.CompareTag("Obs3"))
        {
            restart3.FireEvent();
        }
    }
}
