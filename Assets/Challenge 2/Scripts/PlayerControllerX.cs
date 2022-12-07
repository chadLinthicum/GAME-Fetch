using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // Floats for preventing space spam
    private float spawnTimeInterval = 1; // Interval between dog spawns
    private float timerX; // Timer for the interval


    private void Start()
    {
        // For the first spawn, timer is 1 which means we can spawn a dog
        timerX = spawnTimeInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // This starts the timer
        timerX += Time.deltaTime;
        // If space is down and timer is equal or bigger than 1 we can spawn a dog
        if (Input.GetKeyDown(KeyCode.Space) && timerX >= spawnTimeInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Resets timer back to 0
            timerX = 0;
        }

    }
}