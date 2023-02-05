using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerObstaculos : MonoBehaviour
{
    [SerializeField] GameObject[] obstaculo;
    [SerializeField] REvents changeBackGround;
    //[SerializeField] REvents[] restartPos;
    [SerializeField] int change;
    [SerializeField] float tiempoNegro;
    private void Awake()
    {
        changeBackGround.GEvent += ActivateObjs;
        for(int i = 3; i < 9; i++)
        {
            obstaculo[i].SetActive(false);
        }
    }
    void Start()
    {
        change = 0;
    }

    void ActivateObjs()
    {
        StartCoroutine(Change());
    }
    IEnumerator Change()
    {
        yield return new WaitForSeconds(tiempoNegro);
        change++;
        if (change < 2)
        {
            obstaculo[0].SetActive(false);
            obstaculo[1].SetActive(false);
            obstaculo[2].SetActive(false);
            obstaculo[3].SetActive(true);
            obstaculo[4].SetActive(true);
            obstaculo[5].SetActive(true);
        }
        else
        {
            obstaculo[3].SetActive(false);
            obstaculo[4].SetActive(false);
            obstaculo[5].SetActive(false);
            obstaculo[6].SetActive(true);
            obstaculo[7].SetActive(true);
            obstaculo[8].SetActive(true);
        }
    }
    private void OnDestroy()
    {
        changeBackGround.GEvent -= ActivateObjs;
    }
}
