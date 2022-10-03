﻿using UnityEngine;

public class HealPlayer : MonoBehaviour {

    public float heal = 20f;

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Enemy")) {
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if(enemyHealth.canHeal && enemyHealth.death && Input.GetKeyUp(KeyCode.E)) {
                Debug.Log("Can Heal");
                enemyHealth.canHeal = false;
                enemyHealth.setNewColor(Color.black);

                PlayerHealth playerHealth = transform.parent.GetComponent<PlayerHealth>();

                playerHealth.health += heal;
                if (playerHealth.health > 100f)
                    playerHealth.health = 100f;

                playerHealth.setHealthBar();
            }
        }
    }

}
