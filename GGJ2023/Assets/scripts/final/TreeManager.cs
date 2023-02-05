using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    [SerializeField] GameObject[] tree;
    [SerializeField] REvents[] arbol;
    [SerializeField] Animator[] animT;
    [SerializeField] int[] puntajes;
    [SerializeField] int puntajeFinal;
    [SerializeField] float tiempoPantalla;
    
    void Start()
    {
        puntajeFinal = PlayerPrefs.GetInt("puntaje");
        for(int i = 0; i < 5; i++)
        {
            tree[i].SetActive(false);
        }
        EmpezarSeleccion();
    }
    void EmpezarSeleccion()
    {
        StartCoroutine(WaitScreen());
    }
    IEnumerator WaitScreen()
    {
        yield return new WaitForSeconds(tiempoPantalla);
        SelectTree();
    }
    void SelectTree()
    {
        if (puntajeFinal >= puntajes[4])
        {
            tree[4].SetActive(true);
            animT[3].SetBool("playAnim", true);
            arbol[4].FireEvent();
            return;
        }
        else if (puntajeFinal >= puntajes[3])
        {
            tree[3].SetActive(true);
            animT[2].SetBool("playAnim", true);
            arbol[3].FireEvent();
            return;
        }
        else if (puntajeFinal >= puntajes[2])
        {
            tree[2].SetActive(true);
            animT[1].SetBool("playAnim", true);
            arbol[2].FireEvent();
            return;
        }
        else if (puntajeFinal >= puntajes[1])
        {
            tree[1].SetActive(true);
            animT[0].SetBool("playAnim", true);
            arbol[1].FireEvent();
            return;
        }
        else if (puntajeFinal >= puntajes[0])
        {
            tree[0].SetActive(true);
            arbol[0].FireEvent();
            return;
        }

    }
    
}
