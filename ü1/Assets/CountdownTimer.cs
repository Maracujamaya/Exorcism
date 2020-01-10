using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public string levelToLoad;
    public float timer = 10f;
    public Text timerSeconds;

   

    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");

        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }

    }
}
