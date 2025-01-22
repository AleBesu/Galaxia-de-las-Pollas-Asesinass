using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;


public class MenuFuncions : MonoBehaviour
{
 
 public String playSceneName = "PlayingScene";

  public void playGame(){
  
    SceneManager.LoadScene(playSceneName);


  }






}
