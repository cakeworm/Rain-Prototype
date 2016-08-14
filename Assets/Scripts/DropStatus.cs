using UnityEngine;
using System.Collections;

public class DropStatus : MonoBehaviour 
{
    public bool scalingOne = false;



   

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Surface")
        {
            Destroy(this.gameObject);
        }

                  
        

    }
 

  
}



     



