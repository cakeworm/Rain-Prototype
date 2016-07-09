using UnityEngine;
using System.Collections;

public class RainMaker : MonoBehaviour 
{
   
    public GameObject dropPrefab;
    public bool raining = true;
    public GameObject raindrop;

 
  

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
            GameObject raindrop = (GameObject) Instantiate(dropPrefab, position, Quaternion.identity);

            raindrop.name = "raindrop";

         

        }
    }
   

}
       
     

