using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timerText;
    
    private Vector3 _startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        //timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            timerIsRunning = false;
            GameObject.Find("Player").GetComponent<PlayerMovement>().transform.position = _startingPosition;
            GameObject.Find("Game Session").GetComponent<SceneFader>().FadeInUI();
            GameObject.Find("Game Session").GetComponent<Timer>().timeRemaining = 300;
            GameObject.Find("Game Session").GetComponent<Score>()._coinCount = 0;
            GameObject.Find("Game Session").GetComponent<Score>().DisplayCoinCount();
        }
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);    
    }

    public void StartGameTimer()
    {
        timerIsRunning = true;
    }
}
