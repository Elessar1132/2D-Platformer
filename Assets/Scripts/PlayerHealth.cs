using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int playerHealth = 10;
    GameObject player;
    GameObject healthBar;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TakeDamage(int damage)
    {
        playerHealth -= damage;
    }

    int GetHealth()
    {
        return playerHealth;
    }

    void SetHealth(int health)
    {
        playerHealth = health;
    }
}
