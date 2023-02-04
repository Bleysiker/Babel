using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPos : MonoBehaviour
{
    [SerializeField] float limitX,limitY;
    [SerializeField] Vector3 posL, negL;
    
    private void Awake()
    {
        posL.x = limitX;
        posL.y = limitY;
        negL.x = -limitX;
        negL.y = limitY;
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
            else if (transform.position.x < -limitX)
            {
                transform.position = negL;
            }
        
    }
}
