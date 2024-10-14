using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    int scoreGame;

    void Update()
    {
        scoreGame += 1;
        //scoreGame = scoreGame +1;
        scoreUI.text = scoreGame.ToString();
    }
}
