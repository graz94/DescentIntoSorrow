using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damageAmount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Assuming the player has the PlayerHealth script attached
            other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }
}
