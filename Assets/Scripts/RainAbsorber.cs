using UnityEngine;
using System.Collections;

public class RainAbsorber : MonoBehaviour 
{

    void OnTriggerEnter(Collider other)
    {
        Debug.Log ("The drop has hit " + this.name); 

       if (other.gameObject.tag == "drop")
       {
        Destroy (other.gameObject);
       }

         
             
    }
}
