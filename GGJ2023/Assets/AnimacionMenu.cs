using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMenu : MonoBehaviour
{
    [SerializeField] CanvasGroup trandparencia;
    [SerializeField] CanvasGroup transparenciaTexto;
    [SerializeField] GameObject fondoYBotones;
    [SerializeField] GameObject frase;

    private void Start()
    {
        
    }
    public void PlayMover()
    {
        fondoYBotones.GetComponent<CanvasGroup>().blocksRaycasts = false;
        LeanTween.moveY(fondoYBotones.GetComponent<RectTransform>(), 1080, 5f).setDelay(.5f)
           .setOnComplete(SpawnFrase);
       
    }

   
    private void SpawnFrase()
    {
        trandparencia.LeanAlpha(1, 2f).setDelay(.5f).setOnComplete(ErradicateFrase); 
        
    }
    private void ErradicateFrase()
    {
        transparenciaTexto.LeanAlpha(0, 2f).setDelay(1.5f);
    }

}
