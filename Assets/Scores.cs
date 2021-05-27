using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KartGame;
using UnityEngine.Playables;
using System;
using System.IO;
using TMPro;



public class Scores : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Map1;
    [SerializeField] TextMeshProUGUI m_Map2;
    [SerializeField] TextMeshProUGUI m_Map3;

    // Start is called before the first frame update
    void Start()
    {
        DateTime map1 = DateTime.Parse(File.ReadAllText(Application.streamingAssetsPath + "/Map_IUTRecord.txt"));
        m_Map1.text = map1.Minute.ToString("00") + ":" + map1.Second.ToString("00") + ":" + map1.Millisecond.ToString("00");
        DateTime map2 = DateTime.Parse(File.ReadAllText(Application.streamingAssetsPath + "/Map_VikingRecord.txt"));
        m_Map2.text = map2.Minute.ToString("00") + ":" + map2.Second.ToString("00") + ":" + map2.Millisecond.ToString("00");
        DateTime map3 = DateTime.Parse(File.ReadAllText(Application.streamingAssetsPath + "/Map_WinterRecord.txt"));
        m_Map3.text = map3.Minute.ToString("00") + ":" + map3.Second.ToString("00") + ":" + map3.Millisecond.ToString("00");


    }

    // Update is called once per frame
    void Update()
    {

    }
}
