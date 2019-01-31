using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Singleton : MonoBehaviour 
{ 
    private static Singleton _instance;

    public static Singleton Instance 
    { 
        get { return _instance; } 
    } 

    
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

}