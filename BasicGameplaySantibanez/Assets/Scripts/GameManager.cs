using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    public GameObject gameOverText;
    public Text scoreText;
    public Text livesText;

    private void Awake()
    {
        livesText.text = "Lives: " + lives.ToString(); 
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AnimalFeed(int value)
    {
            score += value;
        if(score <= 0)
        {
            score = 0;
        }
         scoreText.text = "Score: " + score.ToString();
         //Debug.Log("Score = " + score);
    }
    public void Lives(int value)
    {
        lives += value;

        if (lives <=0)
        {
            gameOverText.SetActive(true);
            lives = 0;
        }
        livesText.text = "Lives: " + lives.ToString();
        //Debug.Log("Lives = " + lives);
    }
}
