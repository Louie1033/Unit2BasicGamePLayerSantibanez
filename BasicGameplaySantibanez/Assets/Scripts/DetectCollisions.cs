using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    public int scoreChange = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.Lives(-1);
            gameManager.AnimalFeed(-10);
            
            Destroy(gameObject);
        }
        else
        {

            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManager.AnimalFeed(scoreChange);
        }
    }
}
