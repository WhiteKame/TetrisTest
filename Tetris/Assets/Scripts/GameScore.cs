using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public static Text ScoreText;

    int score;
    int eachLine = 1000;

    public void UpdateScore()
	{
		score += eachLine;
		ScoreText.text = string.Format("{0:D2}", score);
	}
}
