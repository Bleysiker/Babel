using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackGround : MonoBehaviour
{
    [SerializeField] Vector3 moveDir,limit,startPos;
    [SerializeField] float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveDir * speed;
        verifyLimit();
    }
    void verifyLimit()
    {
        if (transform.position.y > limit.y)
        {
            transform.position = startPos;
        }
    }
}
