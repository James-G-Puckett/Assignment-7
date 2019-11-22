using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text playerNameText;
    public Text wordSpeedText;

    //private void Awake()
    //{
    //    playerNameText.text = KeepData.PlayerName;
    //    wordSpeedText.text = KeepData.WordSpeedMultiplier.ToString();
    //}

    void Update()
    {
        playerNameText.text = KeepData.PlayerName;
        wordSpeedText.text = KeepData.WordSpeedMultiplier.ToString();
    }
}
