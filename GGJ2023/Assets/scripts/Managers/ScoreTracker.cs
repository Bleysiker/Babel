using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] REvents gameOver,changeBackground;
    [SerializeField] float time,tbc,t;

    [SerializeField] int[] puntuacion;
    [SerializeField] bool[] background;
    //[SerializeField] ParticleSystem roots;
    bool playing = true;
    int track;
    // Start is called before the first frame update
    void Start()
    {
        score.text = track + " m";
        gameOver.GEvent += GameOver;
        t = tbc;
    }

    // Update is called once per frame
    void Update()
    {
        CaidaRegistrada();
        RecordFall();
    }
    void CaidaRegistrada()
    {
        if (playing == true)
        {
            if (t <= 0)
            {
                track += 1;
                score.text = track + " m";
                t = tbc;
            }
            else {
                t -= 0.05f;
            }
            
        }
        
    }
    void RecordFall()
    {
        if (track > puntuacion[5])
        {
            changeBackground.FireEvent();
            return;
        }
        else if (track > puntuacion[4] & background[4] == false)
        {
            changeBackground.FireEvent();
            background[4] = true;
            return;
        }
        else if(track > puntuacion[3] & background[3] == false)
        {
            changeBackground.FireEvent();
            background[3] = true;
            return;
        }
        else if (track > puntuacion[2] & background[2] == false)
        {
            changeBackground.FireEvent();
            background[2] = true;
            return;
        }
        else if (track > puntuacion[1] & background[1] == false)
        {
            changeBackground.FireEvent();
            background[1] = true;
            return;
        }
        else if (track > puntuacion[0]&background[0]==false)
        {
            changeBackground.FireEvent();
            background[0] = true;
            return;
        }
    }
    void GameOver()
    {
        
        StartCoroutine(Finish());
    }
    IEnumerator Finish()
    {
        playing = false;
        //roots.Play();
        yield return new WaitForSeconds(1f);
        Time.timeScale = time;
    }
}
