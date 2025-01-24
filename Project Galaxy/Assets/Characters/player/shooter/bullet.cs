using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
   public Shooter shooter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        



        transform.Translate( Vector3.up * Time.deltaTime * 10  );
    }


    private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "enemy")
        {   
            other.gameObject.GetComponent<Salud>().saludActual --;
            
             Destroy(gameObject);
        }
    }

    
}
