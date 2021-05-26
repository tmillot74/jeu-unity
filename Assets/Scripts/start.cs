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

    
    // Start is called before the first frame update
    void Start()
    {
        m_PressToStart.text = "Press space button to start";
        StopGame();

    }

    float time = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_PressToStart.text = "";
            StartCoroutine(Decompte());
            time -= Time.deltaTime;
        }
    }

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
    void OnGUI()
    {
        GUI.Label(new Rect(511,240,50,25), time.ToString());
    }

    void StopGame()
    {

    }

    void StartGame(){
        
    }
    
}
