using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    public float speed  = 6f;
    Vector3 movement; 
    Rigidbody playerRigidbody;

    void Awake()
    {
    playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw ("Horizontal");
        float v = Input.GetAxisRaw ("Vertical");
        float d = Input.GetAxisRaw ("Dive");

        Move (h,v, d);
    }

    void Move(float h, float v, float d)
    {
    movement.Set (h, d, v);

    movement = movement.normalized *speed * Time.deltaTime;

    playerRigidbody.MovePosition(transform.position + movement);
    }

    /*void Turning()
    {

    }
    */
}
