using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;


public class MenuFuncions : MonoBehaviour
{
 
 public String historySceneName = "HistoryScene";

  public void playGame(){
  
    SceneManager.LoadScene(historySceneName);


  }






}
