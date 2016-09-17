using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float fallSpeed = 8.0f;
    public float moveSpeed = 4.0f;
    public float dashSpeed = 29.0f;
	
    /*PLAYER CONTROLLED MOVEMENTS*/

	void FixedUpdate ()

	{
        Fall();
        Movement ();
	}

    void Fall()
    {
        this.transform.Translate (new Vector3 (0, 0, fallSpeed * Time.deltaTime));
    }

	void Movement ()
	{

	    if (Input.GetKey (KeyCode.UpArrow)) 
        {
	       
            this.transform.Translate (new Vector3 (0, moveSpeed *Time.deltaTime, 0 ));
	    } 

	    else if (Input.GetKey (KeyCode.DownArrow)) 
        {
	      
            this.transform.Translate (new Vector3 (0, -moveSpeed * Time.deltaTime, 0 ));
	    } 

	    if (Input.GetKey (KeyCode.LeftArrow)) 
	    {
		   
		    
            this.transform.Translate (new Vector3 (-moveSpeed * Time.deltaTime, 0, 0));

	    }

	    else if (Input.GetKey (KeyCode.RightArrow)) 
	    {
		    
			
            this.transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0, 0));
		    
	    }

	    if (Input.GetKey (KeyCode.W)) 
	    {
	        
            this.transform.Translate (new Vector3 (0, 0, -moveSpeed * Time.deltaTime ));

	    }
	    else if (Input.GetKey (KeyCode.S))
   	    {
	       

            this.transform.Translate (new Vector3 (0, 0, dashSpeed * Time.deltaTime));
	    }
	}



    /*OTHER MOVEMENTS*/

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Surface")
        {
            
            Vector3 startPosition = this.transform.position;
            //Vector3 targetDistance = new Vector3 (0, 0, -18.8f);
            //for the move to target business to work, I think the target(s) need to be rotated to be facing the same
            //direction as the cam and the player. 
            //Vector3 moveDelta = this.transform.position - startPosition;



            transform.position = new Vector3 (Random.Range(-25.0F, 25.0F), 750f, Random.Range(-25.0F, 25.0F));
            Camera.main.transform.position = this.transform.position;

        }

                  
        

    }

}
