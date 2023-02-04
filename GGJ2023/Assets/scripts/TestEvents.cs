using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvents : MonoBehaviour
{
    [SerializeField] REvents evento;
    // Start is called before the first frame update
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            evento.FireEvent();
        }
    }
}
