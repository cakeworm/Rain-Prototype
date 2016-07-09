using UnityEngine;
using System.Collections;

public class Absorb : MonoBehaviour 
{

       
        public bool scalingOne = false;
    //bool scalingTwo = false;
   
   void Awake()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
      if (this.gameObject.transform.localScale.sqrMagnitude >= 25*25*25)
      return;
       
       else if (other.gameObject.tag == "Drop")
       {
        this.gameObject.transform.localScale += new Vector3(5,5,5);
       }
    }

   	/*void Update()
    {
        if (this.gameObject.transform.localScale.x >= 25 && scalingOne == false)
        {

            ScaleUp();    

        }
    }

    void ScaleUp()
    {
        GameObject RainManager = GameObject.Find ("RainManager");
        RainManager rainManager = RainManager.GetComponent<RainManager>();
        rainManager.drop.transform.localScale -= new Vector3 (4,4,4);
        scalingOne = true;
    }*/

   







    }