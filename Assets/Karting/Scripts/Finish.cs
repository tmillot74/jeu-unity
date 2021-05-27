using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    Timer m_Timer;

    // Start is called before the first frame update
    void Start()
    {
        m_Timer = FindObjectOfType<Timer>();
        DebugUtility.HandleErrorIfNullFindObject<Timer, GameFlowManager>(m_Timer, this);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            Debug.Log("Fin");
            m_Timer.EndGame();
            LoadA("Menu_Fin");
        }
    }
    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
