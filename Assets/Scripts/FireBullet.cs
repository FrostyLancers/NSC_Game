using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bullet;
    public float BulletSpeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 Direction = mousePosition - transform.position;
        float distance = Direction.magnitude;

        GameObject FireBullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        FireBullet.GetComponent<Rigidbody2D>().velocity = Direction.normalized * BulletSpeed;
        //FireBullet.GetComponent<Rigidbody2D>().velocity = FirePoint.right * BulletSpeed;

        //if (worldPosition.x < transform.position.x)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
        //    FireBullet.GetComponent<Rigidbody2D>().velocity = FirePoint.right * BulletSpeed;
        //}
        ////right side
        //else
        //{
        //    transform.localScale = new Vector3(-1, 1, 1);
        //    FireBullet.GetComponent<Rigidbody2D>().velocity = FirePoint.right * BulletSpeed;
        //}
    }
}
