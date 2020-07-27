using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pspawnner : MonoBehaviour
{
    public GameObject Red, Green;
    public Text TimerSecond;
    int Timer;
    int NewTimer;
    public static bool Stop;

    public GameObject EndPanel;
    public Text YouWinText;
    public Text Person;
    public Text Score;
    public Text HighScore;
    int ScoreValue;
    int HighScoreValue;

    public GameObject ReplayButton;


    private void Start()
    {
    
            Invoke("Spawn", 2f);
            Timer = 60;
            NewTimer = 60;
   
    }

    private void Update()
    {
       
            Timer = Timer - 1;
            if (Timer == 0)
            {
                Timer = 60;
                NewTimer--;

            }
            TimerSecond.text = "Time :- " + NewTimer.ToString("0");
            if (NewTimer == 0)
            {
                Zero();
                Debug.Log("YeWala");
                Time.timeScale = 0f;
            }
      
    }
    void Spawn()
    {
        if (!Stop)
        {
            Vector2 temp = transform.position;
            temp.y = Random.Range(-4.0f, 4.0f);
            temp.x = Random.Range(-7.7f, 7.7f);
            if (Random.Range(0, 2) > 0)
            {
                Instantiate(Red, temp, Quaternion.identity);
            }
            else
            {
                Instantiate(Green, temp, Quaternion.identity);
            }
            Invoke("Spawn", 1f);
        }
    }
    void Zero()
    {
        Debug.Log("AAAAAAAAAAAAAA");
        Stop = true;
        EndPanel.SetActive(true);
        ReplayButton.SetActive(true);

        GameObject[] RedCollector = GameObject.FindGameObjectsWithTag("Red");
        GameObject[] GreenCollector = GameObject.FindGameObjectsWithTag("Green");
        print(RedCollector.Length);
        print(GreenCollector.Length);
        if (RedCollector.Length > GreenCollector.Length)
        {
            YouWinText.text = "YOU WIN !!";
            Person.text = "Bad Boys Win";
        }
        else if (GreenCollector.Length > RedCollector.Length)
        {
            YouWinText.text = "YOU LOOSE !!";
            Person.text = "Good Boys Win";
        }
        ScoreValue = RedCollector.Length * 10 - GreenCollector.Length * 5;
        PlayerPrefs.SetInt("Score", ScoreValue);
        if (PlayerPrefs.HasKey("HighScore"))
        {
            if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
        Score.text = "Score             :-            " + PlayerPrefs.GetInt("Score");
        HighScore.text = "High Score    :-            " + PlayerPrefs.GetInt("HighScore");
    
       
    }

    public void Replay()
    {
        SceneManager.LoadScene("GamePlay");
        Stop = false;
      Time.timeScale = 1f;
    }

}//end
