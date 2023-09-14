using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject ScoreLabel;

    public int score_num = 0; // ÉXÉRÉAïœêî
    int point = 0;

    public void enemyB()
    {
        this.point += 100;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.ScoreLabel = GameObject.Find("ScoreLabel");
    }

    // Update is called once per frame
    void Update()
    {
        this.ScoreLabel.GetComponent<Text>().text =
            this.point.ToString() + "Point";
        PlayerPrefs.SetInt("ScoreLabel", score_num);
        PlayerPrefs.Save();
    }
}
