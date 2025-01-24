using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BasicEnemy : Enemy
{
    // Start is called before the first frame update
   public GameObject enemyBullet;
   float cargandoDisparo =0;
  public float MinimotiempoDisparo =2;
   public float MaximotiempoDisparo =10;
  
   float tiempoEntreDisparos;
   public float distanciaDeMovimientoX = 2;
   protected float posicionInicialX;
   public float direccionYRangoDeMovimientoX =  1.5f;
   public float objetivoX;



    


    void Start()
    { 
      posicionInicialX = transform.position.x;
      objetivoY = gameObject.transform.position.y -2;

      }
  
    void Update()
    {       
          movimiento();

 
          if (zonaDedisparoDespejada)
          {
             
             shoot();
          }
          
     
     
        


    }

   void movimiento (){
 
   
    objetivoX = posicionInicialX + direccionYRangoDeMovimientoX;


      transform.Translate(new Vector3(direccionYRangoDeMovimientoX,0,0) * Time.deltaTime *2 );
 
    

   if (direccionYRangoDeMovimientoX > 0 && transform.position.x > objetivoX ||
        direccionYRangoDeMovimientoX < 0 && transform.position.x < objetivoX)
    {
   
        objetivoX *= -1;
        direccionYRangoDeMovimientoX *= -1;

        
    }

     cargandoY += Time.deltaTime;
     if (cargandoY >= tiempoDeCargaY -1 && transform.position.y >=objetivoY)
     {
      transform.Translate(Vector3.down * Time.deltaTime *2);

     }

     if (transform.position.y <= objetivoY)
     {
      objetivoY = transform.position.y -2;
      cargandoY = 0;
     }



 




   }




   










    void shoot (){

     cargandoDisparo += Time.deltaTime;
  
     if (cargandoDisparo >= tiempoEntreDisparos)
     {
      GameObject nuevoDisparo = Instantiate<GameObject>(enemyBullet,new  Vector3(transform.position.x,transform.position.y - 1,transform.position.z),enemyBullet.transform.rotation);
     


     tiempoEntreDisparos = Random.Range( MinimotiempoDisparo,MaximotiempoDisparo);
    cargandoDisparo  = 0;
     }
          

    }









}