using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiewalk : MonoBehaviour {
    protected Animator myAnimation;
    public float speed = 1.6f;
	// Use this for initialization
	void Start () {
        myAnimation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        myAnimation.SetFloat("speed", speed);
       
	}
}
