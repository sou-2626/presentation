using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private Text scoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GetComponent<Text>();
        scoreLabel.text = "SCORE:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        // 「amount」に入ってくる数値分を加算していく。
        score += amount;
        scoreLabel.text = "SCORE:" + score;
    }
}
