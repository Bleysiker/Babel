using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPos : MonoBehaviour
{
    [SerializeField] float limitX;
    [SerializeField] Vector3 posL, negL;
    private void Awake()
    {
        posL.x = limitX;
        negL.x = -limitX;
    }
    void Update()
    {
        Range();
    }
    void Range()
    {
        if (transform.position.x > limitX)
        {
            transform.position = posL;
        }
        else if(transform.position.x < -limitX)
        {
            transform.position = negL;
        }
    }
}
