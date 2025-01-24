using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDePuntos : MonoBehaviour
{    
    public float generationTim = 3;
    float cargando = 0;
   public GameObject elementoAGenerar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
       float posicionRandomX = Random.Range(-7,7);


        cargando += Time.deltaTime;

          if (cargando >= generationTim)
          {
           GameObject instancia = Instantiate(elementoAGenerar,new Vector3(posicionRandomX,10,0),elementoAGenerar.transform.rotation);
          
          cargando = 0;
          generationTim +=2;
          }

        
    }
}
