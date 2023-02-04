using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed,speedLimit;
    [SerializeField] float x;
    [SerializeField] Vector2 force;
    [SerializeField] float tiempoClick;
    double tD,tI;
    Rigidbody2D rb;

    [SerializeField] bool der, izq;
    

    // Start is called before the first frame update
    void Awake()
    {
        der = true;
        izq = true;
        tD = 0;
        tI = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            rb.AddForce(force * speed);
            der = false;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(force * -(speed+x));
            izq = false;
        }

        ContadorTiempo(der, tD, tiempoClick);
        ContadorTiempo(izq, tI, tiempoClick);
        LimitarVelocidad();
    }
    void ContadorTiempo(bool direccion,double tiempoControl,float tiempoF)
    {
        if (direccion == false)
        {
            tiempoControl += 0.1;
        }
        if (tiempoControl >= tiempoF)
        {
            direccion = true;
            tiempoControl = 0;
        }
    }
    void LimitarVelocidad()
    {
        if (rb.velocity.magnitude > speedLimit)
        {
            rb.velocity = rb.velocity.normalized*speedLimit;
        }
    }
    //IEnumerator EsperarClick()
    //{
    //    yield return new WaitForSeconds(tiempoClick);
    //}
}
