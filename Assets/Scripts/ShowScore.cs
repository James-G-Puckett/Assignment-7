using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText;

    private void Awake()
    {
        scoreText.text = "Score: " + WordDisplay.Score.ToString();
    }
    private void Update()
    {
        scoreText.text = "Score: " + WordDisplay.Score.ToString();
    }
}
