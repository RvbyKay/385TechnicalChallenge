using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAI : MonoBehaviour {
    // General state machine variables 
    public GameObject player; 
    private Animator animator; 
    private float maxDistanceToCheck = 5.0f; 
    private float currentDistance; 
    private Vector3 checkDirection; 

	// Use this for initialization
	void Start () {
        //player = GameObject.FindWithTag("Player"); 
        animator = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate() {
		currentDistance = Vector3.Distance(player.transform.position, transform.position); 
        animator.SetFloat("distanceFromPlayer", currentDistance); 
	}
}
