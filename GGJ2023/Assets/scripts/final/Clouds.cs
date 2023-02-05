using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [SerializeField] Vector3 dir,posIni;
    [SerializeField] float speed,limitX;
    [SerializeField] bool contrario;
    // Start is called before the first frame update
    void Start()
    {
        posIni = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir*speed*Time.deltaTime);
        if (contrario == false)
        {
            if (transform.position.x > limitX)
            {
                transform.position = posIni;
            }
        }
        else
        {
            if (transform.position.x < limitX)
            {
                transform.position = posIni;
            }
        }
    }
}
