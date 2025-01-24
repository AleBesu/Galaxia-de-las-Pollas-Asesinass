
using UnityEditor.SceneManagement;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   public Camera camera;
    CameraRestrictionsMove cameraRestrictionsMove;
    
    private void Start() {
        cameraRestrictionsMove = Camera.main.GetComponent<CameraRestrictionsMove>();
    }
  

    // Update is called once per frame
    void Update()
    {  
       


        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = transform.position.z;
       
       
        mousePosition = camera.ScreenToWorldPoint(mousePosition);
  
        cameraRestrictionsMove.elementPosicion = mousePosition;
        
        
        
 
        transform.position = new Vector3(cameraRestrictionsMove.posicionMaX  ,cameraRestrictionsMove.posicionMaY ,transform.position.z);
        
        
//  mousePosition.x <= 8.2f && mousePosition.x >= -8.2f ? mousePosition.x : transform.position.x

    }
}
