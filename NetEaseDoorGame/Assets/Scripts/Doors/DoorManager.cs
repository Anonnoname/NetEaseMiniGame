﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{


    public float dooropentime;

    DoorTeleport door1;
    DoorTeleport door2;
    // Start is called before the first frame update
    void Start()
    {
        door1 = gameObject.transform.Find("Door1").GetComponent<DoorTeleport>();
        door2 = gameObject.transform.Find("Door2").GetComponent<DoorTeleport>();
        door1.opentime = dooropentime;
        door2.opentime = dooropentime;

       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
