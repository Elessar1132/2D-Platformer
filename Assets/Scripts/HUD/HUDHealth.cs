using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHealth : MonoBehaviour
{
    public Health PlayerHealth;
    public Image HealthImage;
    public Text HealthText;

    private void Start()
    {
        if(PlayerHealth == null)
        {
            GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");
            if (PlayerObj)
            {
                PlayerHealth = PlayerObj.GetComponent<Health>();
                PlayerHealth.onHealthChange += UpdateHealthText;
                HealthText.text = PlayerHealth.GetCurrentHealth().ToString();
            }
        }
        else
        {
            PlayerHealth.onHealthChange += UpdateHealthText;
            HealthText.text = PlayerHealth.GetCurrentHealth().ToString();
        }
    }

    void UpdateHealthText()
    {
        HealthText.text = PlayerHealth.GetCurrentHealth().ToString();
    }
}
