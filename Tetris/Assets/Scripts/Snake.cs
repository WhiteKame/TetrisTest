using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class Snake : MonoBehaviour
{

    private float previousTime;
    public float fallSpeed = 1;

    public bool allowRotation = true;
    public bool limitRotation = false;

    public static int width = 24;
    public static int height = 30;

    //public Canvas canvas;
    int score;

    Text scoreText;


    bool ate = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        score = int.Parse(scoreText.text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore()
    {
        score = score + 2000;
        scoreText.text = score.ToString();
        Debug.Log(score);
        PlayerPrefs.SetInt("score", score);
    }

    void SetScore()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            ate = true;
            Debug.Log("Ate");
            Destroy(other.gameObject);
            AddScore();
        }
    }
}
