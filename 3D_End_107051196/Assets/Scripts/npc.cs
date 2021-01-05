using UnityEngine;
using UnityEngine.UI;
using System.Collections; 


public class npc : MonoBehaviour
{
    [Header("npc 資料")]
    public npcData data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話者名稱")]
    public Text textName;
    [Header("對話間隔")]
    public float interval = 0.1f;



    public bool playerInArea;

    public enum npcState
    {
        FirstDialog, Missioning, Finish
    }

    public npcState state = npcState.FirstDialog;

    //private void Start()
    //{
    //    StartCoroutine(Test());
    //}

    //private IEnumerator  Test()
    //{
    //    print("嗨~");
    //    yield return new WaitForSeconds(1.5f);
    //    print("嗨，我是一點五秒後");
    //    yield return new WaitForSeconds(2);
    //    print("嗨，又過去兩秒了");

    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "robot")
        {
            playerInArea = true;
            StartCoroutine(Dialog());
        }
       

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "robot")
        {
            playerInArea = false;
            StopDialog();
        }                  
    }

    /// <summary>
    /// 停止對話
    /// </summary>
    private void StopDialog()
    {
        dialog.SetActive(false);
        StopAllCoroutines();
    }

    /// <summary>
    /// 開始對話
    /// </summary>
    /// <returns></returns>
    private IEnumerator Dialog()
    {
        dialog.SetActive(true);
        
        textContent.text = "";

        textName.text = name;

        string dialogString = data.dialogB;

        switch (state)
        {
            case npcState.FirstDialog:
                dialogString = data.dialogA;
                break;
            case npcState.Missioning:
                dialogString = data.dialogB;
                break;
            case npcState.Finish:
                dialogString = data.dialogC;
                break;
            
        }

        for (int i = 0; i < dialogString.Length; i++)
        {
            //print(data.dialogA[i]);
            textContent.text += dialogString[i] + "";
            yield return new WaitForSeconds(interval);

        }
        
    }


}
