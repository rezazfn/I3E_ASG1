/*
* Author: Reza
* Date: 13/05/2024
* Description: Door that opens and closes when player is in collider, and presses the [E] to interact button
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Checks if door is opened or closed
    bool opened = false;

    // When the player interacts with the door
    void OnInteract()
    {
        // Upon interaction, door is opened
        OpenDoor();
    }
     
    // When the door opens or closes
    public void OpenDoor()
    {
        // When the door is closed
        if(!opened)
        {
            // Stores Vector3 as a new variable
            Vector3 newRotation = transform.eulerAngles;
            // Modify the rotation of the door to open
            newRotation.y -= 90f;
            // Assigns the new variable as the transform value
            transform.eulerAngles = newRotation;
            // Change the door to opened
            opened = true;
        }

        // When the door is opened
        else
        {
            // Stores Vector3 as a new variable
            Vector3 newRotation = transform.eulerAngles;
            // Modify the rotation of the door to close
            newRotation.y += 90f;
            // Assigns the new variable as the transform value
            transform.eulerAngles = newRotation;
            // Change the door to closed
            opened = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
