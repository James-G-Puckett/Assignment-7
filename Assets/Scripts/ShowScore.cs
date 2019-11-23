using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText;
    public Text missedText;
    public Text highScoreText;

    private void Awake()
    {
        scoreText.text = "Score: " + WordDisplay.Score.ToString();
        missedText.text = "Words missed: " + WordDisplay.MissedScore.ToString();
        highScoreText.text = "High Score: " + WordDisplay.highScore.ToString();
    }
    private void Update()
    {
        scoreText.text = "Score: " + WordDisplay.Score.ToString();
        missedText.text = "Words missed: " + WordDisplay.MissedScore.ToString();
        highScoreText.text = "High Score: " + WordDisplay.highScore.ToString();
    }
}
