using GoogleVR.Demos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportZone : MonoBehaviour {
    DemoSceneManager manager;
    Gun gun;
    public Vector3 position;
    
    // Use this for initialization
    void Start() {
        manager = FindObjectOfType<DemoSceneManager>();
        gun = FindObjectOfType<Gun>();
    }

    // Update is called once per frame
    void Update() {

    }
    public void TeleportPlayer()
    {
        
            position = new Vector3(
            transform.position.x,
            transform.position.y + manager.playerHeight,
            transform.position.z);
        manager.TeleportLocation(position);
    }
}

