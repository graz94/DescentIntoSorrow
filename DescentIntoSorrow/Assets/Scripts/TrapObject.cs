using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class TrapObject : MonoBehaviour
{
    public int damageAmount = 1;
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log($"{name} Triggered");
            other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }
}
