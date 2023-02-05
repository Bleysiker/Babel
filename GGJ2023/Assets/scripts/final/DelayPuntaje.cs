using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DelayPuntaje : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI puntaje,opcion;
    [SerializeField] CanvasGroup transparencia,tpO,w2;
    [SerializeField] REvents reproducirAnim,gameOver;
    [SerializeField] float aparicion,tiempoAnim,tiempoPantalla;
    [SerializeField] int puntajeFinal;
    [SerializeField] string mensajeFinal,mensajeOpcion;
    void Start()
    {
        w2.alpha = 0;
        gameOver.GEvent += Reiniciar;
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
    void Reiniciar()
    {
        StartCoroutine(ReiniciarFast());
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
    IEnumerator ReiniciarFast()
    {
        w2.LeanAlpha(1, 1);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Juanes");
    }
    private void OnDestroy()
    {
        gameOver.GEvent -= Reiniciar;
    }
}
