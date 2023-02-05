using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkipIntro : MonoBehaviour
{
    [SerializeField] CanvasGroup transparencia,whiteS;
    [SerializeField] float transicion,esperaIntro,transicionW;
    [SerializeField] REvents inicioJuego,saltarIntro;

    // Start is called before the first frame update
    void Start()
    {
        inicioJuego.GEvent += AppearButton;
        saltarIntro.GEvent += SkipIntroduccion;
    }

    void AppearButton()
    {
        StartCoroutine(AparecerBoton());
    }
    IEnumerator AparecerBoton()
    {
        yield return new WaitForSeconds(esperaIntro);
        transparencia.LeanAlpha(1, transicion);
    }
    void SkipIntroduccion()
    {
        StartCoroutine(CargarEscena());
    }
    IEnumerator CargarEscena()
    {
        whiteS.LeanAlpha(1, transicionW);
        yield return new WaitForSeconds(transicionW+1);
        SceneManager.LoadScene("Main");
    }
    private void OnDestroy()
    {
        inicioJuego.GEvent -= AppearButton;
        saltarIntro.GEvent -= SkipIntroduccion;
    }
}
