using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    [SerializeField] float delay;
    [SerializeField] REvents evento;
    void Start()
    {
        evento.GEvent += ReproducirSonido;
    }

    void ReproducirSonido()
    {
        StartCoroutine(PlaySounds());
    }
    IEnumerator PlaySounds()
    {
        yield return new WaitForSeconds(delay);
        sound.Play();
    }
    private void OnDestroy()
    {
        evento.GEvent -= ReproducirSonido;
    }
}
