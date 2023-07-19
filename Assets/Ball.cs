using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public void AddForce(Vector2 vector)
    {
        rigidBody.AddForce(vector * speed);
    }

    // Private

    private Rigidbody2D rigidBody;
    private readonly float speed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();

        Vector2 startingVector = generateStartingVector();
        AddForce(startingVector);
    }

    Vector2 generateStartingVector()
    {
        float horizontalAxis = Random.value < 0.5f ? 1 : -1;
        float verticalAxis = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                                   Random.Range(1f, 0.5f);

        return new Vector2(horizontalAxis, verticalAxis);
    }
}
