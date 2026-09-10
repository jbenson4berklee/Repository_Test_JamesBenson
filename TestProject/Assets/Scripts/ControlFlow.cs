using System;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
   public bool flag = true;
   
   public void Start()
   {
      if(flag == false)
      {
         Debug.Log("Boolean flag is set");
      }
      else
      {
         Debug.Log("Boolean flag isn't set");
      }
      
      //public float listLength = 10;
      for (int i = 0; i < 11; i++)
      { 
         float result = Mathf.Pow(2, i);
         Debug.Log($"The {i} power of 2 is {result}");
        
      }
      
   }
}
