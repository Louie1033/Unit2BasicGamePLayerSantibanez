using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class DetectCollisions : MonoBehaviour
{

    private int lives = 3;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lives--;
            Debug.Log("Lives Left: " + lives);
            Debug.Log("Game Over!");
            
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
