using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAndReload : MonoBehaviour
{
    [SerializeField] CanvasGroup transparencia;
    [SerializeField] float aparicion,tiempoAntesdefrase;
    [SerializeField] REvents loadGame;
    // Start is called before the first frame update
    void Start()
    {
        loadGame.GEvent += LoadGame;
        transparencia.LeanAlpha(0,aparicion);
    }
    void LoadGame()
    {
        StartCoroutine(Cargar());
    }
    IEnumerator Cargar()
    {
        yield return new WaitForSeconds(tiempoAntesdefrase);
        SceneManager.LoadScene("Main");
    }
    private void OnDestroy()
    {
        loadGame.GEvent -= LoadGame;
    }
}
