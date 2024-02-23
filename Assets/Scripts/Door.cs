﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform doorEntryPosition;

    public void OpenDoor ()
    {
        // teleport the player to 'doorEntryPosition'
        FindObjectOfType<Player>().transform.position = doorEntryPosition.position;
    }
}