using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    TextMeshProUGUI scoreDisplay;
    int totalScore = 0;
    public static int score = 2;
    private void Awake()
    {
        scoreDisplay = GameObject.Find("ScoreDisplay").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Basketball")
        {
            AddScore();
        }
    }
    void AddScore()
    {
        totalScore += score;
        scoreDisplay.text = "Score : " + totalScore;
    }
    void ChangeScore(int _score)
    {
        score = _score;
    }
}
