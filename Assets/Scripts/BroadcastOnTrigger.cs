﻿using UnityEngine;
using System.Collections;

public class BroadcastOnTrigger : MonoBehaviour
{
    public string message;
    public string argument;
    void OnTriggerEnter()
    {
        //col is the name of the object that enters the trigger
        Messenger.Broadcast<string>(message, col.name);
    }
}
