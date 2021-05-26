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
    [SerializeField] Text m_PressToStart;
    [SerializeField] Text m_Decompte;
    [SerializeField] Text m_Chrono;

    
    float nextFire = 0.0f;
    bool start = false;
    double reste = 0;

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
            reste = nextFire - Math.Truncate(nextFire);
            m_Chrono.text = "" + Math.Truncate(nextFire) + " : " + Math.Round(reste,2)*100;
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
