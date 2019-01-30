using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{   

    public Text OScore;
    public Text XScore;
   
   public void UpdateOScore(int _oscore)
   {
       OScore.text = "OScore : " + _oscore.ToString();
   }

   public void UpdateXScore(int _xscore)
   {
       XScore.text = "XScore : " + _xscore.ToString();
   }
}
