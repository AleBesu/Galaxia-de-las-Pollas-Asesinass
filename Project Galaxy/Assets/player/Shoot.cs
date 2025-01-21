using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{ 

    public GameObject bullet;
   public float  cadence =1;

   float timeToShoot = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        timeToShoot += Time.deltaTime;
         


        if (timeToShoot >=  1/ cadence)
        {
       GameObject instanceBullet =     Instantiate(bullet,new Vector3(transform.position.x,transform.position.y +0.1f,transform.position.z),transform.rotation);
      Destroy(instanceBullet,3);
        
        timeToShoot = 0;
        }
    
         
      
        
    }
}
