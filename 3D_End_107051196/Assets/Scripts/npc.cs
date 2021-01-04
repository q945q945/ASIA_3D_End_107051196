﻿using UnityEngine;
using UnityEngine.UI;

public class npc : MonoBehaviour
{
    [Header("npc 資料")]
    public npcData data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;



    public bool playerInArea;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "robot")
        {
            playerInArea = true;
            Dialog();
        }
       

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "robot")
        {
            playerInArea = false;
        }


    }
    private void Dialog()
    {
        for (int i = 0; i < data.dialogA.Length; i++)
        {
            print(data.dialogA[i]);

        }
        
    }


}
