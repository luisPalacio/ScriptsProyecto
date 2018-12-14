using UnityEngine;

public class Gun : MonoBehaviour {
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem muzzeFlash;
    public GameObject ImpactEffect;
    public float impactForce = 30f;
    public GameObject impact;
    public RaycastHit hit;
    public AudioClip audioclip;


    // Update is called once per frame
    void Update () {
		
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
           
        }
	}
     void Shoot()
    {
        muzzeFlash.Play();
        
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
          
        }

        Enemys enemy = hit.transform.GetComponent<Enemys>();


            Target target = hit.transform.GetComponent<Target>();

            if (enemy != null)
            {
            enemy.TakeDamage(damage);
            if (audioclip != null)
            {
                AudioSource.PlayClipAtPoint(audioclip, transform.position);
            }

        }
                if (target != null)
            {

                target.TakeDamage(damage);
                
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            impact=Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 1f);
        }
    }

