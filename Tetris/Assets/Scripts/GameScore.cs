using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public Text ScoreText;

    int score;

    private void Start()
    {
        score = PlayerPrefs.GetInt("score");
        ScoreText.text = score.ToString();
    }
}
