using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float fallSpeed = 23.0f;
    public float moveSpeed = 25.0f;
    public float dashSpeed = 90.0f;
	


	void Update ()

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
	        Debug.Log ("Key UpArrow pressed.");

            this.transform.Translate (new Vector3 (0, moveSpeed *Time.deltaTime, 0 ));
	    } 

	    else if (Input.GetKey (KeyCode.DownArrow)) 
        {
	        Debug.Log ("Key DownArrow pressed.");

            this.transform.Translate (new Vector3 (0, -moveSpeed * Time.deltaTime, 0 ));
	    } 

	    if (Input.GetKey (KeyCode.LeftArrow)) 
	    {
		   
		    Debug.Log ("Key Leftarrow pressed");

            this.transform.Translate (new Vector3 (-moveSpeed * Time.deltaTime, 0, 0));

	    }

	    else if (Input.GetKey (KeyCode.RightArrow)) 
	    {
		    
			Debug.Log ("Key RightArrow pressed");

            this.transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0, 0));
		    
	    }

	    if (Input.GetKey (KeyCode.W)) 
	    {
	        Debug.Log ("Key W pressed.");

            this.transform.Translate (new Vector3 (0, 0, -moveSpeed * Time.deltaTime ));

	    }
	    else if (Input.GetKey (KeyCode.S))
   	    {
	        Debug.Log ("Key S pressed.");

            this.transform.Translate (new Vector3 (0, 0, dashSpeed * Time.deltaTime));
	    }
	}

}
