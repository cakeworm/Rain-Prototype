using UnityEngine;
using System.Collections;

public class LightningManager : MonoBehaviour
{
    public GameObject LightningParticles;

    // initialize and hide particle system in random.range; vertical up and down is fine for now
    void Start()
    {
	    StartLightning();
    }
	
    // reveal particle layer; pause particles; delete particle system; fire lightning; flashing light; camera rumble
    //reset hidden particle system in random.range
    void Update()
    {
	
    }

    void StartLightning()
    {
        Vector3 position = new Vector3(Random.Range(-25.0F, 25.0F), 900f, Random.Range(-25.0F, 25.0F));

        Instantiate(LightningParticles, position, transform.rotation);
        LightningParticles.name = "Lightning Particles";    
    }
}

