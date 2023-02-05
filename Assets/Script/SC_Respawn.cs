using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor;
using UnityEngine;

public class SC_Respawn : MonoBehaviour
{
    private SC_Timer timer;
    public Transform wobbleRespawn;
    [SerializeField] private bool canRespawn;
    [SerializeField] private int timeBeforeRespawn;

    void Start()
    {
        canRespawn = true;
        timer = FindObjectOfType<SC_Timer>();
    }

    void Update()
    {
        if (timer.sec >= timeBeforeRespawn && canRespawn)
        {
            //faire spawn le cursor au meme endroit que le player
            this.transform.position = wobbleRespawn.transform.position;
            canRespawn = false;
        }
    }
}
