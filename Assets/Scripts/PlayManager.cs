using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayManager : MonoBehaviour
{   
    private Rule rule;
    private GameObject UI_M;
    public string[] tempArray;
    public string SpawnType;
    public int Moves=0;

    
     void Start()
    {
        rule = new Rule();
        ReInit();
    }


    public void ReInit()
    {   

        Array.Clear(rule.ZoneData, 0, rule.ZoneData.Length);
        Array.Clear(tempArray, 0, tempArray.Length);
        rule.SpawnString = "X";

        SpawnType = rule.SpawnString;
        tempArray = rule.ZoneData;

        UI_M = GameObject.FindGameObjectWithTag("UIMgr");
        SetScore();
    }

    public void ZoneDataUpdate(int index)
    {
        rule.ZoneData[index] = SpawnType;
    }

    public void AlternateSpawn()
    {
        SpawnType = rule.AlternateSpawnString();
    }

    public void CheckCondition()
    {   
        bool condition = rule.GameConditionCheck();
        if(condition)
        {   
            if(SpawnType == "X")
            {
                Singleton.Instance.XScore ++;
                UI_M.GetComponent<UIManager>().UpdateXScore(Singleton.Instance.XScore);
            }
            else if(SpawnType == "O")
            {
                Singleton.Instance.OScore ++;
                UI_M.GetComponent<UIManager>().UpdateOScore(Singleton.Instance.OScore);
            }

            Debug.Log("Game Over");
            UI_M.GetComponent<UIManager>().DisplayPanel();
        }

        else if(Moves == 9)
        {
            Debug.Log("Game Over");
            UI_M.GetComponent<UIManager>().DisplayPanel();
        }


    }

    private void SetScore()
    {
        UI_M.GetComponent<UIManager>().UpdateXScore(Singleton.Instance.XScore);
        UI_M.GetComponent<UIManager>().UpdateOScore(Singleton.Instance.OScore);
    }
}
