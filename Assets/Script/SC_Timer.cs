using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class SC_Timer : MonoBehaviour
{
    public float sec;
    public float min;
    public float currentTime;
    [SerializeField] float startingTime;

    [SerializeField] TextMeshProUGUI countdownText;

    void Awake()
    {
        sec = startingTime;
    }

    private void Start()
    {
        StartCoroutine(timeCount());
    }

    private void Update()
    {
        
    }

    IEnumerator timeCount()
    {
        sec = 0;
        min = 0;
        currentTime = 0;

        while (true)
        {
            sec += 1;
            currentTime += 1;
            if (sec >= 60)
            {
                sec = 0;
                min += 1;
            }

            if (sec <= 9)
            {
                countdownText.text = $"Time: {min}min {sec}sec";
            }
            else
            {
                countdownText.text = $"Time: {min}min {sec}sec";
            }
            yield return new WaitForSeconds(1);
        }
    }
}