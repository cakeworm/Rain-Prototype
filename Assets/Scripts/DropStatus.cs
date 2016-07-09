using UnityEngine;
using System.Collections;

public class DropStatus : MonoBehaviour 
{
    public bool scalingOne = false;



   

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

                  
        

    }
 

  
}



     



