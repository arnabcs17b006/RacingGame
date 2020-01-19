﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 100.0F;
    private float direction;
    public Canvas RestartMenu;
    public Transform trans;
    public Text text;
    public int speed=1000;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    		direction = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(direction * Time.deltaTime * moveSpeed * speed/1000, 0);
            speed=speed+1;
            if(speed>1000){
            	text.text="cout<<p--;\na. 12\nb. 10\nc. 21";
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        RestartMenu.gameObject.SetActive(true);
        Destroy(gameObject);
        
        

        
    }
}
