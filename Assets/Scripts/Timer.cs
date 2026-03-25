using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

{
    public float timerRemaining = 5f;
    public bool timerRunning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (timerRemaining > 0)
            {
                timerRemaining -= Time.deltaTime;
            }
            else
            {
                timerRemaining = 0;
                timerRunning = false;
                Debug.Log("TimerEnded");
            }
        }
    }
}
