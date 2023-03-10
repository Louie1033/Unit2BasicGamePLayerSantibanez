using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    public Text scoreText;
    public Text livesText;

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
            Debug.Log("Score = " + score);
    }
    public void Lives(int value)
    {
        lives += value;

        if (lives <=0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
}
