using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI highestScoreText;

    void Start()
    {
        int highestScore = PlayerPrefs.GetInt("HighestScore", 0); 
        highestScoreText.text = "Highest Duck Score: " + highestScore;
    }
}
