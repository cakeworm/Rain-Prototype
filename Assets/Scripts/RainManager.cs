using UnityEngine;
using System.Collections;

public class RainManager : MonoBehaviour 
{

    
    public GameObject drop;             //The drop type to be spawn (only one right now)
    public float spawnTime = 1f;        //How long between each spawn


    void Start()
    {
       InvokeRepeating ("Rain",0.1f, 1.0f);
    }

    void Rain()
    {
        Vector3 position = new Vector3(Random.Range(-14.0F, 14.0F), 70f, Random.Range(-14.0F, 14.0F));
        Instantiate(drop, position, Quaternion.identity);
        drop.name = "drop";

    }


}
