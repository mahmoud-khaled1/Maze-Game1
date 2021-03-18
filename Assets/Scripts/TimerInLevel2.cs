using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerInLevel2 : MonoBehaviour
{

    //public string levelToload;
    private float minute = 0f;
    private float seconds = 59;
    private Text TimerSecond;
    // Start is called before the first frame update
    void Start()
    {
        TimerSecond = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (minute <= 0)
        {
            changeColor();
        }
        if (seconds <= 0)
        {
            if (minute <= 0)
            {
                SceneManager.LoadScene("Level 2");
            }
            else
            {
                minute--;
                seconds = 59;
            }
        }
        TimerSecond.text = minute.ToString() + ":" + seconds.ToString();
    }

    void changeColor()
    {
        TimerSecond.color = new Color(255, 0, 0);
    }
}
