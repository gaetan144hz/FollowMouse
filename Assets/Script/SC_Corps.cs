using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Corps : MonoBehaviour
{
    private SC_FollowMouse corps;
    
    [SerializeField] private bool canSpawn;
    [SerializeField] private GameObject wobbleCorps;
    [SerializeField] private float waitingTime;

    void Start()
    {
        corps = this.GetComponent<SC_FollowMouse>();
        StartCoroutine(spawnCorps());
    }

    void Update()
    {
        
    }

    IEnumerator spawnCorps()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(waitingTime);
            Instantiate(wobbleCorps, corps.transform.position, corps.transform.rotation);
        }
    }
}
