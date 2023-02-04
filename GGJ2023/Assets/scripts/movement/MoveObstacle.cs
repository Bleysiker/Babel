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
    
    Rigidbody2D rb;
    [SerializeField] bool followSeed,move;
    [SerializeField] float profundidad,offsetPos,limitX,limitY;
    [SerializeField] float tbm;
    void Awake()
    {
        startPos.x = Random.Range(-limitX, limitX);
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

        offsetPos = Random.Range(2, 5);
        if (followSeed == true)
        {
            startPos.x = seed.position.x ;
        }
        else
        {
            startPos.x = Random.Range(-limitX, limitX);
            profundidad = Random.Range(limitY - offsetPos, limitY);
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
