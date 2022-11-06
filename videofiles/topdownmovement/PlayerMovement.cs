using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Controls how fast the player moves
    public float Speed;

    // Gets and controls the players position
    public Transform PlayerTransform;

    public void Update()
    {
        // Gets the players input and sets it to a float
        float InputX = Input.GetAxisRaw("Horizontal");
        float InputY = Input.GetAxisRaw("Vertical");

        // Calculates what to set the players position to and then sets it to a float
        float MoveX = PlayerTransform.position.x + InputX * Speed * Time.deltaTime;
        float MoveY = PlayerTransform.position.y + InputY * Speed * Time.deltaTime;

        // Sets the players transform position
        PlayerTransform.position = new Vector3(MoveX, MoveY, 0);
    }
}
