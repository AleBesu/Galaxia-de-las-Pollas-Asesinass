using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BasicEnemy : Enemy
{
    // Start is called before the first frame update
   public GameObject enemyBullet;
   float cargandoDisparo =0;

   public float tiempoMaximoDeDisparo =20;
   float tiempoEntreDisparos;

  
   



    


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
    cargandoX+= Time.deltaTime;
   
    objetivoX = posicionInicialX + direccionYRangoDeMovimientoX;
    if (cargandoX>= tiempoDeCargaX )
    {
      Debug.Log("cargando");
      transform.Translate(new Vector3(direccionYRangoDeMovimientoX,0,0) * Time.deltaTime *2 );
 
    }

   if (direccionYRangoDeMovimientoX > 0 && transform.position.x > objetivoX ||
        direccionYRangoDeMovimientoX < 0 && transform.position.x < objetivoX)
    {
   
        objetivoX *= -1;
        direccionYRangoDeMovimientoX *= -1;

        
        cargandoX = 0;

        Debug.Log("Llegó al objetivo, cargandoX reiniciado");
    }

     cargandoY += Time.deltaTime;
     if (cargandoY >= tiempoDeCargaY && transform.position.y >=objetivoY)
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

    cargandoDisparo  = 0;
     }
          tiempoEntreDisparos = Random.Range ( 1,tiempoEntreDisparos);

    }









}
