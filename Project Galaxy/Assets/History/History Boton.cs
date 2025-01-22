using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HistoryBoton : MonoBehaviour
{
   public HistoryManager historyManager;
   public String playingScene = "PlayingScene";

   public void nextChapter (){
        if (historyManager.actualIndex == historyManager.chapterList.Length -1)
    {
      SceneManager.LoadScene(playingScene);
    }
    if (historyManager.actualIndex <historyManager.chapterList.Count() -1 )
    {
      historyManager.actualIndex ++;
    }


   

  }
  public  void previousChapter (){
    if (historyManager.actualIndex > 0)
    {
      historyManager.actualIndex --;
    }
   

  }


 private void Update() {
    if (historyManager.actualIndex == historyManager.chapterList.Length -1)
  {
    gameObject.GetComponent<TextMeshProUGUI>().text = "JUGAR";
  }
 }


 










}
