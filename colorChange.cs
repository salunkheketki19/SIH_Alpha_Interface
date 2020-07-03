using system.collections;
using system.collection.Generic;
using UnityEngine;
public class colorpicker : MonoBehaviour
{
   public material[] bodycolorMat;
   Material currMat;
   Renderer renderer;
   
  // Use this for initialization
  void start()
  {
     renderer = this.Getcomponent<Renderer>();
  }
  // Update is called once per frame
  void Update()
  {
  
  }
  //render blue color
  public void Bluecolor()
  {
   renderer.material = BodycolorMat[0];
   current = renderermaterial;
  }
  //render red color
  public void Redcolor()
  {
   renderer.material = BodycolorMat[1];
   currMat = renderermaterial;
  }
  //render green color
  public void Greencolor()
  {
   renderer.material = BodycolorMat[2];
   currMat = renderermaterial;
  }
  //render yellow color
  public void Yellowcolor()
  {
   renderer.material = BodycolorMat[3];
   currMat = renderermaterial;
  }
  
}