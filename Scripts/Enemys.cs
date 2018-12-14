﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour {

    public GameObject destroyedVersion;
    public float health = 100f;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
