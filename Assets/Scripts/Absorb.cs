using UnityEngine;
using System.Collections;

public class Absorb : MonoBehaviour 
{
    void OnTriggerEnter(Collider other)
    {
       
       if (other.gameObject.tag == "drop")
       {
        Destroy (other.gameObject);
        this.gameObject.transform.localScale += new Vector3(5,5,5);
       }


    }
}
