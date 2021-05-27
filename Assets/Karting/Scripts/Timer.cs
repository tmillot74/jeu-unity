using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KartGame;
using UnityEngine.Playables;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] Text m_Chrono;

    
    float nextFire = 0.0f;
    bool start = false;
    DateTime time;
    

    // Start is called before the first frame update
    void Start()
    {
        time = new DateTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            nextFire += Time.deltaTime;
            TimeSpan timeSpan = TimeSpan.FromSeconds(nextFire);
            m_Chrono.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00") + ":" + timeSpan.Milliseconds.ToString("00");
        }
    }

    public void StopGame()
    {
        start = false;
    }

    public void StartGame()
    {
        start = true;
    }
    
}
