using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDoor : MonoBehaviour
{
    // Public variables to assign in the Unity Inspector
    public GameObject objectToSpawn; // The object to be spawned
    public Vector2 spawnPosition; // The position to spawn the new object

    // OnTriggerEnter2D is called when the Collider other enters the trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the fake door
            Destroy(gameObject);

            // Spawn the new object at the specified spawn position
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
