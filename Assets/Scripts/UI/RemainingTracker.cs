/*
* Author: Reza
* Date: 14/05/2024
* Description: Tracks and updates remaining collectibles left on screen when a colletible is collected
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class RemainingTracker : MonoBehaviour
{
    // Defines which is the 'remaining collectibles left' text in Unity Editor
    public Text remainingText;
    // Remaining collectibles left reflected across all scripts
    public static int remainingCount = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the remaining collectibles left on the screen
        remainingText.text = "Remaining Gems: " + Mathf.Round(remainingCount);
    }
}