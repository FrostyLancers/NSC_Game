using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public GameObject[] HP_Bar;
    public int HealthLeft = 4;
    public GameObject Blackscreen;
    public Text GameOverText;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Healeh Decrease: " + HealthLeft + "Left.");
            Destroy(other.gameObject);
            HP_Bar[HealthLeft].SetActive(false);
            HealthLeft--;
        }

        if (HealthLeft < 0)
        {
            Time.timeScale = 0;
            Blackscreen.SetActive(true);
            GameOverText.gameObject.SetActive(true);
        }
    }
}
