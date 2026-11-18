using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TextMeshProUGUI timerText;

    private bool timerFinished = false;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = 0;

            if (!timerFinished)
            {
                timerFinished = true;
                TimerFinished();
            }
        }

        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeRemaining <= 10)
        {
            timerText.color = Color.red;
        }
    }

    void TimerFinished()
    {
        Debug.Log("Time's Up!");
    }
}