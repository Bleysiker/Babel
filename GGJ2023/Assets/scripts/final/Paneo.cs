using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneo : MonoBehaviour
{
    [SerializeField] REvents[] arbol;
    [SerializeField] Vector3[] posicionf;
    [SerializeField] float tiempoMov;
    
    void Start()
    {
        transform.position = posicionf[0];
        arbol[0].GEvent += Arbol1;
        arbol[1].GEvent += Arbol2;
        arbol[2].GEvent += Arbol3;
        arbol[3].GEvent += Arbol4;
        arbol[4].GEvent += Arbol5;
    }

    void Arbol1()
    {
        transform.LeanMove(posicionf[0],tiempoMov).setEaseOutQuart();
    }
    void Arbol2()
    {
        transform.LeanMove(posicionf[1], tiempoMov).setEaseOutQuart();
    }
    void Arbol3()
    {
        transform.LeanMove(posicionf[2], tiempoMov).setEaseOutQuart();
    }
    void Arbol4()
    {
        transform.LeanMove(posicionf[3], tiempoMov).setEaseOutQuart();
    }
    void Arbol5()
    {
        transform.LeanMove(posicionf[4], tiempoMov).setEaseOutQuart();
    }
    private void OnDestroy()
    {
        arbol[0].GEvent -= Arbol1;
        arbol[1].GEvent -= Arbol2;
        arbol[2].GEvent -= Arbol3;
        arbol[3].GEvent -= Arbol4;
        arbol[4].GEvent -= Arbol5;
    }
}
