﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public float speed;
    public float initialCurrent;
    public Rigidbody2D player;
    public float currentSpeed;
    private Vector2 direction = Vector2.zero;
    private Vector2 movement;
    //public OxygenMaster oxygen;

    // Update is called once per frame
    void Update()
    {
        // Player movement from input (it's a variable between -1 and 1) for
        // degree of left or right movement
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        movement = new Vector2(horizontal, vertical);
        player.AddForce(movement * speed * Time.deltaTime);
    }
    
} 
