/*
* Author: Reza
* Date: 14/05/2024
* Description: Tracks and updates score count on screen when a colletible is collected
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    // Defines which is the 'total score collected so far' text in Unity Editor
    public Text scoreText;
    // Total score so far reflected across all scripts
    public static int scoreCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the total score collected so far on the screen
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }
}
