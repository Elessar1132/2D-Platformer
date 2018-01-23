using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct EnemyData
{
    public string Name;
    public int Health;
    public int Damage;
}

[RequireComponent(typeof(BoxCollider2D), typeof(SpriteRenderer))]
public class BaseEnemy : MonoBehaviour
{
    public EnemyData Data;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Health collisionHealth = collision.gameObject.GetComponent<Health>();
            if(collisionHealth)
            {
                collisionHealth.TakeDamage(Data.Damage);
                Debug.Log("Hit Player For " + Data.Damage);
            }
        }
    }
}
