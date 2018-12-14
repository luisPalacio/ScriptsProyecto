using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLook : MonoBehaviour {
    Gun gun;
    private RaycastHit lastRaycastHit;
    public AudioClip audioclip;
   
    // Use this for initialization
    void Start () {
		
	}
	private GameObject GetLookedAtObject()
    {
        Vector3 origin = transform.position;
        Vector3 direction = Camera.main.transform.forward;
        float range = 100f;
        if (Physics.Raycast(origin, direction, out lastRaycastHit, range))
            return lastRaycastHit.collider.gameObject;
        else
            return null;

    }
    private void TeleporLookAt()
    {
        transform.position = lastRaycastHit.point + lastRaycastHit.normal * 2; 
        if (audioclip != null)
            AudioSource.PlayClipAtPoint(audioclip, transform.position);
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            if (GetLookedAtObject() != null)
                //gun.hit.transform.name 

              // if (gun.hit.collider.gameObject.name == "Floor_B")

                
                    TeleporLookAt();
                

        
	}
}
