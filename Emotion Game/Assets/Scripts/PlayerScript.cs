using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    [System.Serializable]

    public class PlayerStats
    {
        public float playerHealth = 100f;
    }

    public PlayerStats playerStats = new PlayerStats();

    void Update ()
    {
        if (ScoreScript.playerScore >= 250)
        {
            DamagePlayer(200);
        }
    }

    public void DamagePlayer(float damage)
    {
        playerStats.playerHealth -= damage;
        if (playerStats.playerHealth <= 0)
        {
            GameManagementScript.KillPlayer(gameObject);
        }
    }
}
