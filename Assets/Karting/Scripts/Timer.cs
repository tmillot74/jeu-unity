using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KartGame;
using UnityEngine.Playables;
using System;
using System.IO;


public class Timer : MonoBehaviour
{
    [SerializeField] Text m_Chrono;


    float nextFire = 0.0f;
    bool start = false;
    float min;
    float sec;
    float milli;
    TimeSpan timeSpan;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            nextFire += Time.deltaTime;
            timeSpan = TimeSpan.FromSeconds(nextFire);
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

    public void EndGame()
    {

        string ok = File.ReadAllText(Application.streamingAssetsPath + "/" + SceneManager.GetActiveScene().name + ".txt");
        Debug.Log(timeSpan.ToString());
        string temps = timeSpan.ToString();
        string ancienTemps = File.ReadAllText(Application.streamingAssetsPath + "/" + SceneManager.GetActiveScene().name + ".txt");
        if (DateTime.Parse(temps) < DateTime.Parse(ancienTemps))
            File.WriteAllText(Application.streamingAssetsPath + "/" + SceneManager.GetActiveScene().name + ".txt", temps);
        Debug.Log(ok);
    }
}
