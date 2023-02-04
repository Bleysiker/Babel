using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 moveDir,startPos;
    [SerializeField] float speedLimit;
    [SerializeField] REvents restartPos;
    [SerializeField] Transform seed;
    [SerializeField] float offsetPos;
    Rigidbody2D rb;
    [SerializeField] bool followSeed;
    [SerializeField] float profundidad;
    void Awake()
    {
        transform.position=startPos;
        restartPos.GEvent += RestartPos;
        rb = GetComponent<Rigidbody2D>();
        RestartPos();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveDir * speedLimit;
    }

    void RestartPos()
    {
        offsetPos = Random.Range(1, offsetPos);
        if (offsetPos == 1)
        {
            offsetPos += offsetPos;
        }
        if (followSeed == true)
        {
            startPos.x = seed.position.x + offsetPos;
        }
        else
        {
            if (Random.Range(1, 100) <= 50)
            {
                startPos.x -= offsetPos;
            }
            else
            {
                startPos.x += offsetPos;
            }
            startPos.y = profundidad;
        }
        
        transform.position = startPos;

    }
    private void OnDestroy()
    {
        restartPos.GEvent -= RestartPos;
    }
}
