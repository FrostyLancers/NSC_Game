using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieyMovement : MonoBehaviour
{
    public float speed = 0.1f; // The speed at which the first object should move

    void Start()
    {
        
    }

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            // Calculate the direction and distance to the player
            Vector3 direction = player.transform.position - transform.position;
            float distance = direction.magnitude;

            // Move towards the player at the specified speed
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

        if(player.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
