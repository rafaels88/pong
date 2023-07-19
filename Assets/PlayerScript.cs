using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private readonly float moveSpeed = 10f;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        float move = Input.GetAxisRaw("Vertical");
        Vector2 moveVector = new(0, move);

        rigidBody.velocity = moveVector * moveSpeed;
    }

}
