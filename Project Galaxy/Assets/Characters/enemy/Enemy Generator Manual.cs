using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;

public class GeneradorDeOleadas : MonoBehaviour
{
    
    public float tiempoEntreCargas = 3;

    float cargando = 3;
    public string pathDB;
   
    public  List<GameObject>  enemyList;

    String[] oleadas;
    int oleadaActualIndex = 0;

    TextAsset enemylevelDB;
    float posicionXActual = -8;

    int contador = 0;


   
    // Start is called before the first frame update
    void Start()
    {
     enemylevelDB = Resources.Load<TextAsset>(pathDB);


    if(enemylevelDB == null){


        throw new Exception("Base de datos no encontrada");

    
    }
    oleadas = enemylevelDB.text.Split("\n");



    }

    // Update is called once per frame
    void Update()
    {
    cargando += Time.deltaTime;



     if (cargando >= tiempoEntreCargas && oleadaActualIndex < oleadas.Count() )
     {    

    
       string[] oleadaActual =  oleadas[oleadaActualIndex].Split(" ");
       

       foreach (string item in oleadaActual)
       {
        
        int.TryParse(item,out int tipoDeEnemigo) ;



        if ( tipoDeEnemigo < 0  || tipoDeEnemigo >=enemyList.Count )
        {
            posicionXActual += 2;
        } else
        {
         GameObject newInstance = Instantiate<GameObject>(enemyList[tipoDeEnemigo],new Vector3(x: posicionXActual, y: 5,z:0),enemyList[tipoDeEnemigo].transform.rotation);
          newInstance.GetComponent<BasicEnemy>().tiempoDeCargaY = tiempoEntreCargas;
         newInstance.name = "clon" + contador.ToString() ;
         posicionXActual += 2;
         
        }
         contador ++;
       

       }






        posicionXActual = -8;
        cargando = 0;
        oleadaActualIndex ++;
     }















    }
}
