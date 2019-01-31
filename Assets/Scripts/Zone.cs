using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{   
    public int ZoneID;
    private GameObject PlayMgr;

    private bool HasSpawned=false;

    void Start()
    {
        PlayMgr = GameObject.FindGameObjectWithTag("PlayMgr");
    }
    private void OnMouseDown()
    {
        Spawn();
    }
    private void Spawn()
    {   
        GameObject ToSpawn=null;
        string _spawntype = PlayMgr.GetComponent<PlayManager>().SpawnType;

        if(_spawntype == "X")
        {
            ToSpawn =  Instantiate (Resources.Load ("XObj")) as GameObject; 
        }

        else if(_spawntype == "O")
        {
            ToSpawn =  Instantiate (Resources.Load ("OObj")) as GameObject; 
        }

        if(ToSpawn != null)
        {   
            ToSpawn.transform.SetParent(this.gameObject.transform);
            ToSpawn.transform.localPosition =  new Vector3(0f,0.5f,0f);

            ToSpawn.SetActive(true);
        }


        PlayManager _playmgr = PlayMgr.GetComponent<PlayManager>();

        _playmgr.Moves ++;
        _playmgr.ZoneDataUpdate(ZoneID);        
        _playmgr.CheckCondition();
        _playmgr.AlternateSpawn();

        HasSpawned = true;
    }


}