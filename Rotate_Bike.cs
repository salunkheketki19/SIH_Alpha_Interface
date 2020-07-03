using System.Collection;
using System.Collection;
using UnityEngine;

public class RotateObject : MonoBehaviour 
{
  
   public GameObject objectRotate;
 
   public float      rotateSpeed = 50f;
   bool              rotateStatus = false;

   public void Rotasi ()  {
   
       if (rotateStatus==false) {
           rotateStatus = true;
       }
       else{
            rotateStatus = false;
       }
  }
  
  void Upadte() 
   {
     if (rotateStatus == true)
     {
      objectRotate.transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime);
     }
   }
}
 

    


















