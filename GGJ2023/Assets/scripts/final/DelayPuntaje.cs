using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DelayPuntaje : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI puntaje,opcion;
    [SerializeField] CanvasGroup transparencia,tpO;
    [SerializeField] REvents reproducirAnim;
    [SerializeField] float aparicion,tiempoAnim,tiempoPantalla;
    [SerializeField] int puntajeFinal;
    [SerializeField] string mensajeFinal,mensajeOpcion;
    void Start()
    {
        opcion.text = mensajeOpcion;
        if (PlayerPrefs.GetInt("puntaje") < puntajeFinal)
        {
            puntaje.text = "Te faltaron " + (puntajeFinal - PlayerPrefs.GetInt("puntaje")) + " m" + " para alcanzar el cielo";
        }
        else
        {
            puntaje.text = mensajeFinal;
        }
        transparencia.alpha = 0;
        tpO.alpha = 0;
        StartCoroutine(MostrarPuntaje());
    }

    IEnumerator MostrarPuntaje()
    {
        yield return new WaitForSeconds(tiempoPantalla);
        reproducirAnim.FireEvent();
        yield return new WaitForSeconds(tiempoAnim);
        transparencia.LeanAlpha(1, aparicion);
        yield return new WaitForSeconds(1f);
        tpO.LeanAlpha(1, aparicion);
    }
}
