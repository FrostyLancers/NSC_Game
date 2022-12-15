using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGunAndHead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the mouse
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Convert the mouse position to world space
        //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);

        //mousePosition.x = mousePosition.x - worldPosition.x;
        //mousePosition.y = mousePosition.y - worldPosition.y;

        //float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 270));


        ////left side
        //if (worldPosition.x < transform.position.x)
        //{
        //    transform.localScale = new Vector3(-1, 1, -1);
        //}
        ////right side
        //else
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
        //}
    }
}
