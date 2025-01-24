using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    float cargandoEnemigos = 3;
   public float tiempoEntreCargas = 3;
    public int enemisToGenerate = 9;
    
   public float posicionMinX = -8;

    

    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   /*la variable se llama cargando enemigos ya que va a ser como una barra de carga 
    que se va llenando con diferentes metodos hasta que cuando ya se llena se carga enemigos nuevos
    */
       cargandoEnemigos += Time.deltaTime;

        
        if (cargandoEnemigos >= tiempoEntreCargas)
        {   
            
            for (int i = 0; i< enemisToGenerate;i ++  ){
        
            GameObject newEnemy = Instantiate(enemy,new Vector3(posicionMinX  + i *2  ,5,0),rotation:enemy.transform.rotation);
          
            newEnemy.GetComponent<BasicEnemy>().tiempoDeCargaY = tiempoEntreCargas;

         
            
         
            }
            
  
          cargandoEnemigos = 0;
        }




    }






}
