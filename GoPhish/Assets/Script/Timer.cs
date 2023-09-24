using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

bool timerActive = true;
float currentTime;
public int startSeconds;
public Text currentTimeText;
public bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime=startSeconds;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true) {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0) {
                timerActive = false;
                Debug.Log("Timer expired.");
                timerEnd();
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Seconds.ToString();

        
    }

  

    public void StopTimer() {
        timerActive = false;
    }

    public void timerEnd() {
        if (win) {
            // Win condition
            Debug.Log("Successfully rejected cookies");
        } else {
            // Lose condition
            Debug.Log("Did not reject all cookies");
        }
    }
}
