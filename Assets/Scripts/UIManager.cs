using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{   

    public Text OScore;
    public Text XScore;

    public GameObject Panel;

public void UpdateOScore(int _oscore)
   {
       OScore.text = "O : " + _oscore.ToString();
   }

   public void UpdateXScore(int _xscore)
   {
       XScore.text = "X : " + _xscore.ToString();
   }

   public void DisplayPanel()
   {
       Panel.SetActive(true);
   }

   public void RePlay()
   {
       SceneManager.LoadScene("Main");
   }
}
