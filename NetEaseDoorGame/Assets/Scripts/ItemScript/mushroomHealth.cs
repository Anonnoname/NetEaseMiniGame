﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomHealth : ItemClass
{


    public GameObject Player;
    private PlayerStats playerstat;
    private ItemMananger itemManager;

    public float mushroomHealthGen = 0.8f;

    public Vector3 playerPos;
    public Vector3 playerCurrentPos;


    // Start is called before the first frame update
    private void Awake()
    {
        playerPos = this.transform.position;
       
    }




    void Start()
    {
        SetIcon();
        Collect();
        name = "Regen Mushroom";
        discription = "Regenerate health while standing still";

       
    }

    // Update is called once per frame
    void Update()
    {


       


        if (collected == true) 
        {


            setPlayer();
            playerCurrentPos = Player.transform.position;
            //here is the healthing part

            if (playerPos.x < playerCurrentPos.x ||
                    playerPos.x > playerCurrentPos.x ||
                    playerPos.z < playerCurrentPos.z ||
                    playerPos.z > playerCurrentPos.z)

                {

                Debug.Log("Not the same position");
                }
                else
                {

                    playerstat.currentHealth += mushroomHealthGen * Time.deltaTime;
                    if(playerstat.currentHealth >= playerstat.maxHealth)
                    {
                        playerstat.currentHealth = playerstat.maxHealth;
                    }
                }

                playerPos = playerCurrentPos;
        }
    }

    void setPlayer()
    {
        Player = getPlayer();
        playerstat = Player.GetComponent<PlayerStats>();
        itemManager = Player.GetComponent<ItemMananger>();
    }
}
