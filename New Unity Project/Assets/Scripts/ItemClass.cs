﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemClass : MonoBehaviour
{
    [SerializeField]
<<<<<<< HEAD
   public  Sprite icon;

    public void SetIcon()
    {
        this.GetComponent<SpriteRenderer>().sprite = icon;
    }
    public void SetIcon(Sprite spt)
    {
        this.GetComponent<SpriteRenderer>().sprite = spt;
=======
    public string names;
    [SerializeField]
    public  Sprite icon;
    public bool collected = false;
    
    public void SetIcon()
    {
        this.GetComponent<SpriteRenderer>().sprite = icon;
>>>>>>> 9e3a0a52a70970f6747f4a96b897d700cd03bd49
    }
    public Sprite GetIcon()
    {
        return icon;
    }
    public void Collect()
    {
        this.gameObject.AddComponent<BoxCollider>();
        this.gameObject.GetComponent<BoxCollider>().size= new Vector3(1, 1, 1);
        this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
<<<<<<< HEAD
            other.GetComponent<ItemMananger>().RecieveItem(this);
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }
=======
            collected = true;
            other.GetComponent<ItemMananger>().ReceiveItem(this);

            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
>>>>>>> 9e3a0a52a70970f6747f4a96b897d700cd03bd49
    }

}