using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float tiempoEntreCargas = 3 ;
    float cargando = 0;
    bool enMovimiento = false;
    public float distanciaMinima = -4.5f;
    Vector3 objetivo;


    public float espacioEntreEnemigos = 2;
    
    
    // Start is called before the first frame update
    void Start()
    {
objetivo = new Vector3(transform.position.x,transform.position.y - espacioEntreEnemigos,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    { 
       if (transform.position.y <= distanciaMinima)
       {
        Debug.Log("haz perdido");
       }




        cargando += Time.deltaTime;
        if (cargando >= tiempoEntreCargas && !enMovimiento)
        {
        enMovimiento = true;
        cargando = 0;
        }
        
    if (enMovimiento)
    {transform.position = Vector3.MoveTowards(transform.position,objetivo,10 * Time.deltaTime);


    if (transform.position == objetivo)
    {
    enMovimiento = false;
    objetivo = new Vector3(objetivo.x,objetivo.y - espacioEntreEnemigos,objetivo.z );
    }
    }
    }
   

     private void OnTriggerEnter(Collider other) {
     
        if (other.tag == "bullet")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Lose Zone")
        {
            Debug.Log("Haz perdido");
        }
       
     }



}
