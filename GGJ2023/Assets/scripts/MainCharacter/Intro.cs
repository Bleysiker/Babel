using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] REvents inicioJuego;
    [SerializeField] float tiempoAntesCaida,transcision;
    [SerializeField] Vector3 posF;
    void Start()
    {
        inicioJuego.GEvent += CaerSemilla;
    }

    void CaerSemilla()
    {
        StartCoroutine(Fall());
    }
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(tiempoAntesCaida);
        transform.LeanMove(posF, transcision).setEaseOutQuart();
    }
    private void OnDestroy()
    {
        inicioJuego.GEvent -= CaerSemilla;
    }
}
