using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour 
{

    public Transform player = null;
    public Transform target = null;

   
    public float speedX = 6.0f;
    public float speedY = 2.0f;
    public float speedZ = 4.0f;
    public Vector3 nextPosition = Vector3.zero;

    public enum CameraState {none, followPosition, lookAtPlayer, both};
    public CameraState cameraState = CameraState.none;

    void LateUpdate()
    {
        switch (cameraState)
        {
            case CameraState.none: break;
            case CameraState.followPosition:        FollowPosition ();break;
            case CameraState.lookAtPlayer:        LookAtPlayer (); break;
            case CameraState.both:                  FollowPosition (); LookAtPlayer (); break;

           
        }
      //Look At camera (follows player transform, but not much else)

     //this.transform.position = target.position;
     //follows player, but camera doesn't rotate with player (kind of has one of those
     //weird harness camera effects.) It's also too stiff, and has a jerky movement
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
