using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisapearBlack : MonoBehaviour
{
    [SerializeField] CanvasGroup transparencia;
    [SerializeField] float aparicion;
    [SerializeField] REvents changeBackground,changeObjects;
    [SerializeField] int lvls;
    // Start is called before the first frame update
    void Start()
    {
        changeBackground.GEvent += ChangeBack;
    }

    void ChangeBack()
    {
        StartCoroutine(ChangeB());
    }
    
    IEnumerator ChangeB()
    {
        lvls++;
        if (lvls <= 2)
        {
            transparencia.LeanAlpha(1, aparicion);
            yield return new WaitForSeconds(aparicion);
            changeObjects.FireEvent();
            transparencia.LeanAlpha(0, aparicion);
        }
        
    }
    private void OnDestroy()
    {
        changeBackground.GEvent -= ChangeBack;
    }
}
