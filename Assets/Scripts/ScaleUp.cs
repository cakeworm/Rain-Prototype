using UnityEngine;
using System.Collections;

public class ScaleUp : MonoBehaviour 
{

       
        public bool scalingOne = false;
    //bool scalingTwo = false;
   
  
    void Start()
     {
        
     }
	void Update()
    {
        if (this.gameObject.transform.localScale.x >= 25 && scalingOne == false)
        {
         
            GameObject spawner = GameObject.Find ("spawner");
            RainMaker rainMaker = spawner.GetComponent<RainMaker>();

            //rainMaker.raindrop.transform.localScale -= new Vector3 (1,1,1);
            //need to figure out how to access the localScale of the clones, and not the gotdamn prefab! The lines above
            //scale like they should, but the scaling affects the prefab.

            //A ha! It may be that the coroutine is holding my clones of the dropPrefab. Good to know, but may be tought to getg
            //access to them . . .                         
            scalingOne = true;

        }
    }
}




         