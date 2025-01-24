using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
  
   
   public float distanciaDeMovimientoY = 2;
   protected float cargandoY = 0;
   public float tiempoDeCargaY =3;




   protected float objetivoY;

   [HideInInspector]
   public bool zonaDedisparoDespejada = false;





  
    

}
