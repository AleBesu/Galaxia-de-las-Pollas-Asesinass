using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ArtificialInteligence : MonoBehaviour
{
    public GameObject jugador;
   
    public  List<Collider> listaDeEnemigos ;
    float posicionX = 0;
    float posicionY = -1;
    float loadForMoveY = 0;
    Collider enemigoDetectado ;
    bool enemigoPendientParaAtacar = true;

    float EnemigoMasCercano;

    BoxCollider detectEnemyCollider;
    
    
    // Start is called before the first frame update
    void Start()
    {
        detectEnemyCollider = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {   


        loadForMoveY +=Time.deltaTime;
        if (loadForMoveY >= Random.Range (2,6))
        {
            posicionY = Random.Range (-1,-4);
            loadForMoveY = 0;
        }

        
      


      

    }
    


    
     private void OnTriggerStay(Collider other) {
       
        
  HashSet<Collider> SetDeEnemigos = new HashSet<Collider>();
        if(other.tag == "enemy"){
           
                    SetDeEnemigos.Add(other);
       
        }
        listaDeEnemigos = new List<Collider>(SetDeEnemigos);


        ////////////////////////////////////


        if (enemigoPendientParaAtacar)
        {  
         float distanciaMenorY = float.PositiveInfinity;

         foreach (Collider enemigo in listaDeEnemigos)
         {  
         float distanciaDeEnemigoY =  enemigo.transform.position.y  - jugador.transform.position.y;

          if (distanciaDeEnemigoY< distanciaMenorY)
          {
            distanciaMenorY = distanciaDeEnemigoY;
            enemigoDetectado = enemigo;
          }
          
         }


         foreach (Collider enemigo in listaDeEnemigos)
         {
         float distanciaDeEnemigoX =  enemigo.transform.position.x  - jugador.transform.position.x;
         if (distanciaDeEnemigoX < enemigoDetectado.transform.position.x)
         {
            enemigoDetectado = enemigo;
         }

         }










         posicionX = enemigoDetectado.transform.position.x;
       
         enemigoPendientParaAtacar = false;

        }








          if (enemigoDetectado == null && other.tag == "enemy")
          { 
           
            enemigoPendientParaAtacar = true;
          }
        
         
       
         jugador.transform.position = Vector3.MoveTowards(jugador.transform.position,new Vector3(posicionX,posicionY,0 ) ,Time.deltaTime * 10  );
        
        
        
      
    }
        


    }




