using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{

    
    public static Action<int> UpdateScore;
    public int score = 0;
    public TMP_Text scoreTxt;
    void OnEnable()
    {
        UpdateScore += UpdateScoreAndUI;
        scoreTxt.text = "Score: " + score;
    }

    void OnDisable()
    {
        UpdateScore -= UpdateScoreAndUI;
    }

    void UpdateScoreAndUI(int value)
    {
        score += value;
        scoreTxt.text = "Score: " + score;
    }
}
