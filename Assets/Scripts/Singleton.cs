using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour 
{ 
    private static Singleton _instance;

    public static Singleton Instance 
    { 
        get { return _instance; } 
    } 

    // Parameters

    private Rule rule;

    public string[] tempArray;
    public string SpawnType;

    public int XScore=0;
    public int OScore=0;

    private void Awake() 
    { 
        if (_instance != null && _instance != this) 
        { 
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    } 



    void Start()
    {
        rule = new Rule();
        SpawnType = rule.SpawnString;

        tempArray = rule.ZoneData;
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
                XScore ++;
            }
            else if(SpawnType == "O")
            {
                OScore ++;
            }

            Debug.Log("Game Over");
            GameOver();
        }

    }


    private void SetScore()
    {
        //DisplayScore
    }
    public void GameOver()
    {   
        //Display UI Panel
        GameObject UI = GameObject.FindGameObjectWithTag("UIMgr");
    }

}
