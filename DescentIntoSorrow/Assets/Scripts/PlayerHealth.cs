using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // The maximum health the player can have
    public int maxHealth = 1;

    // The current health of the player
    public int currentHealth;

    // Called when the player is initialized
    void Start()
    {
        // Set the current health to the maximum health when the player is spawned
        currentHealth = maxHealth;
    }

    // Inflicts damage to the player
    public void TakeDamage(int damageAmount)
    {
        // Reduce the current health by the specified damage amount
        currentHealth -= damageAmount;

        // Ensure the current health doesn't go below zero
        if (currentHealth <= 0)
        {
            currentHealth = 0;

            // Call the PlayerDied method to handle death-related logic
            PlayerDied();
        }
    }

    // Handles player death
    void PlayerDied()
    {
        // Add any additional death-related logic here

        // Load the "DeathScreen" scene when the player dies
        SceneManager.LoadScene("GameOver");
    }
}
