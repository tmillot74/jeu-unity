using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KartGame;
public class start : MonoBehaviour
{
    [SerializeField] Text m_PressToStart;
    [SerializeField] Text m_Decompte;
    [SerializeField] Text m_Chrono;

    
    float time;
    public float TimerInterval = 5f;
    float tick;

    // Start is called before the first frame update
    void Start()
    {
        m_PressToStart.text = "Press space button to start";
        StopGame();

    }

    // Update is called once per frame
    void Update()
    {        
        m_Chrono.text = "" + Time.timeSinceLevelLoad.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_PressToStart.text = "";
            StartCoroutine(Decompte());            
        }
    }
    //Compte a rebours 3...2...1...Go !
    IEnumerator Decompte(){
        for (int i=3; i >= 0; i--){
            yield return new WaitForSeconds(1);
            m_Decompte.text = "" + i;
        }
        Debug.Log("debut course");
        StartGame();
        m_Decompte.text = "Go !";
        yield return new WaitForSeconds(2);
        m_Decompte.text = "";
    }

    void StopGame()
    {

    }

    void StartGame(){
        
    }
    
}
