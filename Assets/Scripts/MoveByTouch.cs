using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : NetworkBehaviour
{
    public Player player;

    void Start()
    {
        player = gameObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isLocalPlayer && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            Vector3 touchVector = Camera.main.ScreenToWorldPoint(touch.position);
            Vector3 playerPosition = player.gameObject.transform.position;

            if (touchVector.y > playerPosition.y)
            {
                player.MoveY(1f);
            }
            else if (touchVector.y < playerPosition.y)
            {
                player.MoveY(-1f);
            }
        }
    }
}
