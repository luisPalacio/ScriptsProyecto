using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public float health = 200f;
    Enemys enemy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (health >= 10f)
            {
                TakeDamage(10f);
                    }
                if (health <= 0f)
            {
                Die();
            }
        }
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
       
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
