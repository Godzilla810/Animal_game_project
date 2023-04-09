using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int value){
        score += value;
        Debug.Log("score:" + score);
    }

    public void AddLives(int value){
        lives += value;
        Debug.Log("lives:" + lives);
        if (lives < 1){
            Debug.Log("Game Over!");
            lives = 1;
        }
    }
}
