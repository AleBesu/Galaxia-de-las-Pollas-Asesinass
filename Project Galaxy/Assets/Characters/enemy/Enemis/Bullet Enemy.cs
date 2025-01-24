using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    float velocidad = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * velocidad);
    }



    private void OnTriggerEnter(Collider other) {
        if (other.tag =="Player")
        { 
            
          other.GetComponent<Salud>().saludActual --;

          Destroy(gameObject);
        }
    }
}
