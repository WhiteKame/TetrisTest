using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public Text TimeText;
    //public float gameTime;

    int hour;
    int minute;
    int second;
    //int millisecond;

    float timeSpend = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TimeText.text = gameTime.ToString();

        timeSpend += Time.deltaTime;
        //GlobalSetting.timeSpent = timeSpend;

        hour = (int)timeSpend / 3600;
        minute = ((int)timeSpend - hour * 3600) / 60;
        second = (int)timeSpend - hour * 3600 - minute * 60;
        //millisecond = (int)((timeSpend - (int)timeSpend) * 1000);

        TimeText.text = string.Format("{0:D2}:{1:D2}", minute, second);
    }
}
