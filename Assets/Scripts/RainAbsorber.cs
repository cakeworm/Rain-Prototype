using UnityEngine;
using System.Collections;

public class RainAbsorber : MonoBehaviour 
{

    void OnTriggerEnter(Collider other)
    {
        
       if (other.gameObject.tag == "drop")
       {
        Destroy (other.gameObject);
       }

         
             
    }
}
