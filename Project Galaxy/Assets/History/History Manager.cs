using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HistoryManager : MonoBehaviour
{
    
    public Chapter[] chapterList;
   public int actualIndex = 0;
   public GameObject text;
  public GameObject image;
  int ultimoIndexRegistrado = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (ultimoIndexRegistrado != actualIndex)
    {
     
    text.GetComponent<TextMeshProUGUI>().text =chapterList[actualIndex].text;
    image.GetComponent<Image>().sprite = chapterList[actualIndex].sprite;
   
    ultimoIndexRegistrado = actualIndex;
    }

        
    }
}
