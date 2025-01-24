using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{ 

    public GameObject bullet;
    public int nivel = 0;
    private float progresoDeNivel = 0;
   public float  cadence =1;
   AudioSource audioSource;
   Energia energia;

   float timeToShoot = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        energia = gameObject.GetComponent<Energia>();
    }

    // Update is called once per frame
    void Update()
    { 
        timeToShoot += Time.deltaTime;
        
      
      

        if (timeToShoot >=  1/ cadence && Input.GetMouseButton(0) && energia.energiaActual >=1 )
        {
        audioSource.Play();
       GameObject instanceBullet =     Instantiate(bullet,new Vector3(transform.position.x,transform.position.y +0.1f,transform.position.z),transform.rotation);
        Destroy(instanceBullet,3);
        energia.energiaActual --;
        
        timeToShoot = 0;


     
        }
    
         
      
        
    }
}
