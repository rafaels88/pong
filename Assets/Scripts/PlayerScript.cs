using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : NetworkBehaviour
{
    public void MoveY(float yDirection)
    {
        Vector2 moveVector = new(0, yDirection);

        rigidBody.velocity = moveVector * moveSpeed;
    }

    // Private

    private readonly float moveSpeed = 10f;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if(isLocalPlayer)
        {
            float yDirection = Input.GetAxisRaw("Vertical");
            MoveY(yDirection);
        }
    }

}
