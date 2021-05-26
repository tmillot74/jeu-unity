using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    private void Start()
    {

    }

    public void changeScene(string SceneNameLoad)
    {
        SceneManager.LoadScene(SceneNameLoad);
    }
}
