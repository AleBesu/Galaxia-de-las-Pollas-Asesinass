using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntocadencia : MonoBehaviour
{
    
    float potencia = 0.5f;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" )
        {
            other.GetComponent<Shooter>().cadence += potencia;
        audioSource.Play();
         Destroy(gameObject.GetComponent<Renderer>());
         Destroy(gameObject,3);
        }

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }



    }
}
