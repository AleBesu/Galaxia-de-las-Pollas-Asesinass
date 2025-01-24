using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
  
   
   public float distanciaDeMovimientoY = 2;
   public float distanciaDeMovimientoX = 2;
   public float tiempoDeCargaX =2;
   public float tiempoDeCargaY =5;
   protected float cargandoX = 0;

   public float direccionYRangoDeMovimientoX =  1.5f;
   protected float cargandoY = 0;
   protected float posicionInicialX;


   protected float objetivoX;
   protected float objetivoY;

   [HideInInspector]
   public bool zonaDedisparoDespejada = false;





  
    

}
