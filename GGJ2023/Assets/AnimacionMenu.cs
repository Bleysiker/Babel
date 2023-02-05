using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMenu : MonoBehaviour
{
    [SerializeField] CanvasGroup trandparencia, transparenciaCreditos;
    [SerializeField] CanvasGroup transparenciaTexto;
    [SerializeField] GameObject fondo,credits, BotonesUI;
    [SerializeField] GameObject frase;
    [SerializeField] ParticleSystem ps;

    private void Start()
    {
        
    }
    public void moverWeasMover()
    {
        //fondoYBotones.GetComponent<CanvasGroup>().blocksRaycasts = false;
        LeanTween.moveY(BotonesUI.GetComponent<RectTransform>(), 1020, 4f).setDelay(.5f)
           .setOnComplete(PlayMover);
        ps.Play();


    }
    public void PlayMover()
    {
        //fondoYBotones.GetComponent<CanvasGroup>().blocksRaycasts = false;
        LeanTween.moveY(fondo.GetComponent<RectTransform>(), 13, 5f).setDelay(.5f)
           .setOnComplete(SpawnFrase);
       


    }

   
    private void SpawnFrase()
    {
        trandparencia.LeanAlpha(1, 5f).setDelay(.5f).setOnComplete(ErradicateFrase); 
        
    }
    private void ErradicateFrase()
    {
        transparenciaTexto.LeanAlpha(0, 2f).setDelay(1.5f);
    }

    public void SpawnCredits()
    {
        transparenciaCreditos.LeanAlpha(1, 2f).setDelay(.5f);
        credits.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    public void ErradicateCredits()
    {
        transparenciaCreditos.LeanAlpha(0, 2f).setDelay(1.5f);
        credits.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }


}
