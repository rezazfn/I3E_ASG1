/*
* Author: Reza
* Date: 14/05/2024
* Description: Tracks and updates collected count on screen when a colletible is collected 
and displays congratulations when player collects enough collectibles
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class Congrats : MonoBehaviour
{
    // Defines which is the 'total collected collectibles tracker' text in Unity Editor
    public Text collectedText;
    // Defines which is the 'congratulations' text in Unity Editor
    public GameObject congratsText;
    // Total collectibles collected so far reflected across all scripts
    public static int collectedCount;
    // Allows player to change total amount of collectibles needed to be collected to win in Unity Editor
    public int totalCollectibles;

    // When all collectibles are collected
    public void totalCollected()
    {
        // Check if total collected collectibles match the total in game collectibles
        if(collectedCount >= totalCollectibles)
        {
            // Show congratulations text
            DisplayCongrats();
        }
    }

    // When the congratulations text is displayed
    private void DisplayCongrats()
    {
        // Activate congratulations text to appear on screen
        congratsText.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Deactivate congratulations text to not appear on screen
        congratsText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Update the total collected collectibles so far on the screen
        collectedText.text = "Collected: " + Mathf.Round(collectedCount);
        // Keep checking if total collected collectibles match the total in game collectibles
        totalCollected();
    }
}