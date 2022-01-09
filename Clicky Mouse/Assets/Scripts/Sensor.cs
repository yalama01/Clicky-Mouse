using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sensor : MonoBehaviour
{
    public TextMeshProUGUI uGUIscore;
    public GameObject GameOverPanal;
    public int score;

    private void Start()
    {

        Time.timeScale = 1;
        score = 0;
        uGUIscore.text = "Score:" + score;
    }


    //delets game object and score manager

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Good") && score>5)
        {
            UpdateScore(-5);

        }
        if(other.gameObject.CompareTag("Good") && score<= 5)
        {
            GameOver();
        }

        Destroy(other.gameObject);
    }


    public void UpdateScore(int scoreTo)
    {
        score += scoreTo;

        uGUIscore.text = "Score:" + score;
    }

    public void GameOver()
    {
        GameOverPanal.SetActive(true);
        Time.timeScale = 0f;
    }

    public void restart()
    {
        SceneManager.LoadScene("MainGame");
    }
}
