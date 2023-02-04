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
    [SerializeField] bool followSeed,move;
    [SerializeField] float profundidad;
    [SerializeField] float tbm;
    void Awake()
    {
        transform.position=startPos;
        restartPos.GEvent += RestartPos;
        rb = GetComponent<Rigidbody2D>();
        RestartPos();
        StartCoroutine(TimeBeforeMove());
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            rb.velocity = moveDir * speedLimit;
        }
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
    IEnumerator TimeBeforeMove()
    {
        yield return new WaitForSeconds(tbm);
        move = true;
    }
    private void OnDestroy()
    {
        restartPos.GEvent -= RestartPos;
    }
}
