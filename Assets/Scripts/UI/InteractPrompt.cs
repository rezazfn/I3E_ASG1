/*
* Author: Reza
* Date: 14/05/2024
* Description: Displays interact prompt when player is in collider
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPrompt : MonoBehaviour
{
    // Defines which is the interact text in Unity Editor
    public GameObject Instruction;
    // Defines which collider/area the text will be displayed in Unity Editor
    public GameObject Collider;
    // Checks if text is shown on screen
    public bool Action = false;

    // When collided object enters trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the Player tag
        if(other.gameObject.tag == "Player")
        {
            // Activate interact text to appear on screen
            Instruction.SetActive(true);
            // Change to text is being displayed
            Action = true;
        }
    }

    // When collided object exits trigger
    void OnTriggerExit(Collider other)
    {
        // Check if the collided object has the Player tag
        if(other.gameObject.tag == "Player")
        {
            // Deactivate interact text to not appear on screen
            Instruction.SetActive(false);
            // Change to text is not being displayed
            Action = false;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        // Deactivate interact text to not appear on screen
        Instruction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

