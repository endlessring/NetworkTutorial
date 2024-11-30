using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        if(isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 0.04f, moveVertical * 0.04f, 0);
            transform.position += movement;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
}
