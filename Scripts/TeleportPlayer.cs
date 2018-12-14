using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {

    public float distance = 100f;
    public Vector3 targetLocation;
    void Update()
    {
        /*
         * Create the hit object.
         */
        RaycastHit hit;
        /*
         * Cast a Raycast.
         * If it hits something:
         */
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            /*
             * Set the target location to the location of the hit.
             */
             targetLocation = hit.point;
            /*
             * Modify the target location so that the object is being perfectly aligned with the ground (if it's flat).
             */
            targetLocation += new Vector3(0, transform.localScale.y / 2, 0);
            /*
             * Move the object to the target location.
             */
            transform.position = targetLocation;
        }
    }
}