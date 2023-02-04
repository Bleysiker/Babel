using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] REvents gameOver;
    [SerializeField] float time,tbc,t;
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
                t -= 0.35f;
            }
            
        }
        
    }
    void RecordFall()
    {

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
