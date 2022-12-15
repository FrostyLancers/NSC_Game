using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{
    public GameObject Blackscreen;
    public Text GameOverText;
    public HealthManager HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        int HPValue = HP.HealthLeft;
        if (HPValue < 0)
        {
            Time.timeScale = 0;
            Blackscreen.SetActive(true);
            GameOverText.gameObject.SetActive(true);
        }
    }
}
