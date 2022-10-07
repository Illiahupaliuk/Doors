using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    public float DoorSpeed = 5f;
    BoxCollider2D BoxCollider;
    Vector2 movementVector;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       //Vector2 BoxCollider = new Vector2(movementVector.z*DoorSpeed, rbody.)
        if (BoxCollider.IsTouchingLayers(LayerMask.GetMask("Player"))) 
        {
            Vector2 doorVelocity = new Vector2(movementVector.y, rbody.position.x);
            rbody.velocity = doorVelocity;
        }
        else { return; }
      
    }
   
}
