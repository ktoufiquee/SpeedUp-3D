using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public static int Score;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        scoreText.text = Score.ToString();
    }
}
