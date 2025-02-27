﻿using UnityEngine;

[CreateAssetMenu(fileName ="npc 資料", menuName ="zhen/npc")]
public class npcData : ScriptableObject
{
    [Header("第一段對話"), TextArea(1, 5)]
    public string dialogA;
    [Header("第二段對話"), TextArea(1, 5)]
    public string dialogB;
    [Header("第三段對話"), TextArea(1, 5)]
    public string dialogC;
    [Header("任務項目需求數目")]
    public int count;
    [Header("已經取得項目數量")]
    public int countCurrent;
}
