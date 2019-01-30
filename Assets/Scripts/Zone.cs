using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{   
    public int ZoneID;

    private void OnMouseDown()
    {
        Spawn();
    }
    private void Spawn()
    {   
        GameObject ToSpawn=null;

        if(Singleton.Instance.SpawnType == "X")
        {
            ToSpawn =  Instantiate (Resources.Load ("XObj")) as GameObject;
            
        }

        else if(Singleton.Instance.SpawnType == "O")
        {
            ToSpawn =  Instantiate (Resources.Load ("OObj")) as GameObject;
          
        }

        if(ToSpawn != null)
        {   
            ToSpawn.transform.SetParent(this.gameObject.transform);
            ToSpawn.transform.localPosition =  new Vector3(0f,0.5f,0f);

            ToSpawn.SetActive(true);
        }

        Singleton.Instance.ZoneDataUpdate(ZoneID);
        
        Singleton.Instance.CheckCondition();
        Singleton.Instance.AlternateSpawn();
    }


}