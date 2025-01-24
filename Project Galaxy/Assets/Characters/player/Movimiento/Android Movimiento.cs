using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AndroidMovimiento : MonoBehaviour
{
   public Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
       


        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = touch.position;
        touchPosition.z = transform.position.z;
       
       
        touchPosition = camera.ScreenToWorldPoint(touchPosition);
  

        
        
        
 
        transform.position = new Vector3(  touchPosition.x <= 8.2f && touchPosition.x >= -8.2f ? touchPosition.x : transform.position.x ,touchPosition.y >= -3 && touchPosition.y <=0 ? touchPosition.y : transform.position.y  ,transform.position.z);
        
        


    }
}
