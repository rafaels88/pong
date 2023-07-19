using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public float strengthOnBounce = 0.05f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball)
        {
            Vector2 currentForce = collision.GetContact(0).normal;
            ball.AddForce(-currentForce * strengthOnBounce);
        }
    }
}
