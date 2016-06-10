using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour 
{

    public Transform player = null;
    public Transform target = null;
    public Transform target2D = null;

   
    public float speedX = 6.0f;
    public float speedY = 2.0f;
    public float speedZ = 4.0f;
    public Vector3 nextPosition = Vector3.zero;



    void LateUpdate ()
    {
        if (Input.GetKey("space"))
        {
            FollowPosition2D();
            LookAtPlayer();

        }
        else
        {
            FollowPosition();
            LookAtPlayer();
        }
    }

   


    void FollowPosition2D()

        

        {
            nextPosition.x = Mathf.Lerp (this.transform.position.x, target2D.position.x, speedX * Time.deltaTime);
            nextPosition.y = Mathf.Lerp (this.transform.position.y, target2D.position.y, speedY * Time.deltaTime);
            nextPosition.z = Mathf.Lerp (this.transform.position.z, target2D.position.z, speedZ * Time.deltaTime);
   
            this.transform.position = nextPosition;
        }

    void FollowPosition()
        {
            nextPosition.x = Mathf.Lerp (this.transform.position.x, target.position.x, speedX * Time.deltaTime);
            nextPosition.y = Mathf.Lerp (this.transform.position.y, target.position.y, speedY * Time.deltaTime);
            nextPosition.z = Mathf.Lerp (this.transform.position.z, target.position.z, speedZ * Time.deltaTime);
   
            this.transform.position = nextPosition;
        }

    void LookAtPlayer ()
        {
           this.transform.LookAt (player.position);
        }



}
