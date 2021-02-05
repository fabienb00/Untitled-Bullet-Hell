using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int maxHealth;
    public int currentHealth;
    public int lives;

    public float[] position;

    public PlayerData(PlayerController player)
    {
        maxHealth = player.maxHealth;
        currentHealth = player.currentHealth;
        lives = player.lives;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
