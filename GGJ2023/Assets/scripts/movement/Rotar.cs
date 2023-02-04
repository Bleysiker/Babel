using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    [SerializeField] float speed;
    
    
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation*Time.deltaTime*speed);
    }
    
}
