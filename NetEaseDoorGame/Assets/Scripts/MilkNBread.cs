﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkNBread : ItemClass
{
    public GameObject player;
    private PlayerStats playerStats;

    void Awake()
    {

        //temp implementation (player should get from collision)
        player = GameObject.Find("Player");
        playerStats = player.GetComponent<PlayerStats>();
       
    }
    // Start is called before the first frame update
    void Start()
    {
        names = "牛奶面包";
        SetIcon();
        Collect();

    }

    // Update is called once per frame
    void Update()
    {
        //if player uses the item, increase initial health.
        // NOTE: NEED TO CLEAR THE ITEM LIST AFTER PLAYER USED IT.
        if (Input.GetKey(KeyCode.F) && collected)
        {
            
            playerStats.maxHealth += 15;
            collected = false;
            
        }
    }
}
