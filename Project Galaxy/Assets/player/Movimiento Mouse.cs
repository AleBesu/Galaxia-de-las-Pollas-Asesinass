
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   public Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
       


        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = transform.position.z;
       
       
        mousePosition = camera.ScreenToWorldPoint(mousePosition);
  

        
        
        
 
        transform.position = new Vector3(  mousePosition.x <= 8.2f && mousePosition.x >= -8.2f ? mousePosition.x : transform.position.x ,mousePosition.y >= -3 && mousePosition.y <=0 ? mousePosition.y : transform.position.y  ,transform.position.z);
        
        


    }
}
