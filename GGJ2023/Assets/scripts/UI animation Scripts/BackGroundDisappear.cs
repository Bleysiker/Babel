using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundDisappear : MonoBehaviour
{
    [SerializeField] CanvasGroup transparencia;
    [SerializeField] REvents changeBackground,screenW;
    [SerializeField] int lvls;
    [SerializeField] float aparicion;
    // Start is called before the first frame update
    void Start()
    {
        lvls = 0;
        transparencia.LeanAlpha(0, aparicion);
        changeBackground.GEvent += DestinoFinal;
        screenW.GEvent += ScreenW;
    }

    void DestinoFinal()
    {
        lvls++;
        if (lvls > 5)
        {
            transparencia.LeanAlpha(1, aparicion);
            //aca desaparecen los obstaculos
        }
    }
    void ScreenW()
    {
        
        transparencia.LeanAlpha(1, aparicion);
    }
    private void OnDestroy()
    {
        screenW.GEvent -= ScreenW;
        changeBackground.GEvent -= DestinoFinal;
    }
}
