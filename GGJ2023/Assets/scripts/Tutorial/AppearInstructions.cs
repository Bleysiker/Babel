using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearInstructions : MonoBehaviour
{
    [SerializeField] float delay, timeI, transicion;
    [SerializeField] REvents startGame;
    [SerializeField] CanvasGroup transparencia;
    void Start()
    {
        startGame.GEvent += ReproducirTutorial;
    }
    void ReproducirTutorial()
    {
        StartCoroutine(Tutorial());
    }

    IEnumerator Tutorial()
    {
        yield return new WaitForSeconds(delay);
        transparencia.LeanAlpha(1,transicion);
        yield return new WaitForSeconds(timeI);
        transparencia.LeanAlpha(0, transicion);
    }
    private void OnDestroy()
    {
        startGame.GEvent -= ReproducirTutorial;
    }
}
