using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    private Text scoreText;
    public int score = 0;
    public float rate = 0f;
    public int dusenMeyve = 0;
    public bool GameOver;
  
    

    void Start()
    {
        gameObject.SetActive(true);
        scoreText = GameObject.Find("ScoreText(Clone)").GetComponent<Text>();
        scoreText.text = "0";
    }

    public void  skorArttir()
    {
        score++;
        scoreText.text = score.ToString();
        dusenMeyve++;
        rate = score * 100f / dusenMeyve;
    }

    public void MeyveDustu()
    {
        dusenMeyve++;
        rate = score * 100f / dusenMeyve;
    }
    public void BombaCarpti()
    {
        if (GameObject.Find("Controller").GetComponent<HeartNumber>().heartCount != 0)
        {
            GameObject.Find("Controller").GetComponent<HeartNumber>().lowerCount();
        }
        else
        {
           
            GameObject.Find("Heart(Clone)").SetActive(false);
            GameObject.Find("Controller").GetComponent<GameOverScreen>().createGameOverImage(GameObject.Find("Panel")); 
            gameObject.SetActive(false);
            GameObject.Find("Controller").GetComponent<FruitSpawner>().enabled = false;
            GameOver = true;
            //StartCoroutine(RestartGame());
        }
    }

    //IEnumerator RestartGame()
    //{
    //    yield return new WaitForSecondsRealtime(2f);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
