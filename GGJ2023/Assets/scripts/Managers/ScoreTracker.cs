using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] REvents gameOver,changeBackground,screenWhite,changeMessage,achivementS;
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
                t -= 11*Time.deltaTime;
            }
            
        }
        
    }
    void RecordFall()
    {
        
        if (track > puntuacion[2] & background[2] == false)
        {
            achivementS.FireEvent();
            changeBackground.FireEvent();
            GameOver();
            return;
        }
        else if (track > puntuacion[1] & background[1] == false)
        {
            changeBackground.FireEvent();
            changeMessage.FireEvent();
            achivementS.FireEvent();
            background[1] = true;
            return;
        }
        else if (track > puntuacion[0]&background[0]==false)
        {
            changeBackground.FireEvent();
            achivementS.FireEvent();
            background[0] = true;
            return;
        }
    }
    void GameOver()
    {
        screenWhite.FireEvent();
        StartCoroutine(Finish());
    }
    IEnumerator Finish()
    {
        playing = false;
        PlayerPrefs.SetInt("puntaje", track);
        //roots.Play();
        
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene("Final");
        Time.timeScale = time;
    }
    private void OnDestroy()
    {
        gameOver.GEvent -= GameOver;
    }
}
