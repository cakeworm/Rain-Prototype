using UnityEngine;
using System.Collections;

public class RainMaker : MonoBehaviour 
{
   
    public GameObject raindrop;
    public bool raining = true;
 
  

    void Start()
    {
        StartCoroutine ("rain");
    }

    public IEnumerator rain()
    {
        while (true)
        {                   
            yield return new WaitForSeconds(1);
            Vector3 position = new Vector3(Random.Range(-14.0F, 14.0F), 70f, Random.Range(-14.0F, 14.0F));
            Instantiate(raindrop, position, Quaternion.identity);

            raindrop.name = "Falling Drop";

        }
    }
   

}
       
     

