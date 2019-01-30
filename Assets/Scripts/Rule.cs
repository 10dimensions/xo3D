using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule
{   
    public string SpawnString = "X";
    public string[] ZoneData=new string[9];
    

    public string AlternateSpawnString()
    {
        if(SpawnString == "X")
            SpawnString = "O";

        else if(SpawnString == "O")
            SpawnString = "X";

        return SpawnString;
    }

    public bool GameConditionCheck()
    {   
        if(ZoneData[0]==SpawnString && ZoneData[1]==SpawnString && ZoneData[2]==SpawnString)
        {   
           return true;
        }
        else if(ZoneData[3]==SpawnString && ZoneData[4]==SpawnString && ZoneData[5]==SpawnString)
        {
            return true;
        }
        else if(ZoneData[6]==SpawnString && ZoneData[7]==SpawnString && ZoneData[8]==SpawnString)
        {
            return true;
        }
        else if(ZoneData[0]==SpawnString && ZoneData[3]==SpawnString && ZoneData[6]==SpawnString)
        {
            return true;
        }
        else if(ZoneData[1]==SpawnString && ZoneData[4]==SpawnString && ZoneData[7]==SpawnString)
        {
            return true;
        }
        else if(ZoneData[2]==SpawnString && ZoneData[5]==SpawnString && ZoneData[8]==SpawnString)
        {
            return true;
        }

         else if(ZoneData[0]==SpawnString && ZoneData[4]==SpawnString && ZoneData[7]==SpawnString)
        {
            return true;
        }
         else if(ZoneData[2]==SpawnString && ZoneData[4]==SpawnString && ZoneData[6]==SpawnString)
        {
            return true;
        }

        else
        {
            return false;
        }

        
    }

}
