/*
* Author: Reza
* Date: 13/05/2024
* Description: Destroys Key when collected and allows player to unlock door if they are in the door collider
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Defines which door the key will open
    public Component DoorCollider;   

    // When the player interacts with the collectible 
    void OnInteract()
    {
        // Upon interaction, collectible gets collected
        Collected();
    }

    // When the player collects the collectible 
    public void Collected()
    {
        // Destroys collectible when player collects it
        Destroy(gameObject);
    } 

    // When player remains on the trigger
    void OnTriggerStay()
    {
        // Makes sure the door collider is active to interact and open door
        DoorCollider.GetComponent<BoxCollider>().enabled = true;
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

