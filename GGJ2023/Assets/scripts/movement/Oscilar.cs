using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour
{
    [SerializeField] Transform objeto;
    [SerializeField] Vector3 posicionRelativa,posicionNueva;
    [SerializeField] float speed,oscilationSpeed,amplitud;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        posicionNueva.y = objeto.position.y;
        posicionRelativa.y += speed * Time.deltaTime;
        posicionRelativa.x = Mathf.Sin(posicionRelativa.y * oscilationSpeed) * amplitud;
        posicionNueva.x = posicionRelativa.x;
        transform.localPosition = posicionNueva;
    }
}
