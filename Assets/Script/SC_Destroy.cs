using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Destroy : MonoBehaviour
{
    [SerializeField] private float timeBeforeDestroy;

    void Start()
    {
        Destroy(this.gameObject, timeBeforeDestroy);
    }

    void Update()
    {
        
    }
}
