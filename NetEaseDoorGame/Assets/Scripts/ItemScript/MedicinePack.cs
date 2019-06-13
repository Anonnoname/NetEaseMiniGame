﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicinePack : ItemClass
{
    public GameObject player;
    private ItemMananger itemMananger;
    private PlayerStats pstats;
    public float diffHealth;


    // Start is called before the first frame update
    void Start()
    {
        names = "MedicinePack";
        SetIcon();
        Collect();

    }

    // Update is called once per frame
    void Update()
    {
    	  
    	  
        if (collected)
        {
        
        	setPlayer();
        	

            IncreaseHealth();

			   itemMananger.RemoveItem("MedicinePack");
            collected = false;
            
        }
    }
    void IncreaseHealth()
    {
        //increase player's health by 15
			pstats.currentHealth += 15f;
    }

    void setPlayer()
    {
        player = getPlayer();
        pstats = player.GetComponent<PlayerStats>();
        itemMananger = player.GetComponent<ItemMananger>();
    }
}
