using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    //public Sprite Enemies;
    //public GameObject Position;

    //public Sprite sprite; // The sprite to render
    public GameObject Enemies;
    public Transform position;

    private void Start()
    {
        // Get the sprite renderer component on the instantiated object
        SpriteRenderer renderer = Enemies.GetComponent<SpriteRenderer>();

        // Set the sprite renderer's sprite to the sprite we want to render
        //renderer.sprite = sprite;
        InvokeRepeating("SpawnEnemy", 1.0f, 5.0f);
    }

    void Update()
    {
        //Instantiate(Enemies, position.transform.position, Quaternion.identity);

        // Instantiate the prefab at the origin
        //Instantiate(sprite, position.transform.position, Quaternion.identity);
    }

    private void SpawnEnemy()
    {
        Instantiate(Enemies, position.transform.position, Quaternion.identity);
    }
}
