using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRestrictionsMove : MonoBehaviour
{
    
    [HideInInspector]
    public float posicionMaX;
        [HideInInspector]
    public float posicionMaY;
        [HideInInspector]
    public Vector3 elementPosicion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame



    private void Update() {

     posicionMaX = Mathf.Clamp(elementPosicion.x,transform.position.x -8,transform.position.x + 8);
     posicionMaY = Mathf.Clamp(elementPosicion.y,transform.position.y -4.5f,transform.position.y -1);

    }
  
}
