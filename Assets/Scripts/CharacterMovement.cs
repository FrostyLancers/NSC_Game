using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //private CharacterController player;
    //public float Speed;

    public Rigidbody2D rb;
    public float speed = 5f;


    void Start()
    {
        //player = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Vector3 Move = Vector3.zero;
        //Move.x = Input.GetAxis("Horizontal") * Speed;
        //Move.y = Input.GetAxis("Vertical") * Speed;
        //player.Move(Move * Time.deltaTime);

        // Get the current position of the mouse
        Vector2 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Gradually move the player towards the target position
        rb.position = Vector2.MoveTowards(rb.position, worldPosition, speed * Time.deltaTime);




        //left side
        if (worldPosition.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //right side
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
