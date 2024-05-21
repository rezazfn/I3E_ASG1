/*
* Author: Reza
* Date: 12/05/2024
* Description: Contains functions that allow player to interact in game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Declares variable that references the door object
    private Door door;
    // Declares variable that references the key object
    private Key key;
    // Declares variable that references the locked door object
    private LockedDoor lockedDoor;

    // When the player interacts with objects
    void OnInteract()
    {
        // Checks if the door is not null and does not reference any object
        if (door != null)
        {
            // Calls function from the door object to open the door
            door.OpenDoor();
            
        }

        // Checks if the key is not null and does not reference any object
        if (key != null)
        {
            // Calls function from the key object to collect the key
            key.Collected();
            // Changes key to null
            key = null;
        }
        
        // Checks if the locked door is not null and does not reference any object
        if (lockedDoor != null)
        {
            // Calls function from the locked door object to open the locked door
            lockedDoor.OpenDoor();
            
        }
    }

    // When collided object enters trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the Door tag
        if(other.gameObject.CompareTag("Door"))
        {
            // Assigns door component from GameObject to the door variable
            door = other.GetComponent<Door>();
        }

        // Check if the collided object has the Key tag
        if(other.gameObject.CompareTag("Key"))
        {
            // Assigns key component from GameObject to the key variable
            key = other.GetComponent<Key>();
        }
        // Check if the collided object has the LockedDoor tag
        if(other.gameObject.CompareTag("LockedDoor"))
        {
            // Assigns locked door component from GameObject to the locked door variable
            lockedDoor = other.GetComponent<LockedDoor>();
        }
    }

    // When collided object exits trigger
    private void OnTriggerExit(Collider other)
    {
        // Check if the collided object has the Door tag
        if(other.gameObject.CompareTag("Door"))
        {
            // Changes door to null
            door = null;
        }
        // Check if the collided object has the Key tag
        if(other.gameObject.CompareTag("Key"))
        {
            // Check if the key component from other game object matches the key variable
            if(other.GetComponent<Key>() == key)
            {
                // Changes key to null
                key = null;
            }
        }
        // Check if the collided object has the LockedDoor tag
        if(other.gameObject.CompareTag("LockedDoor"))
        {
            // Changes locked door to null
            lockedDoor = null;
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
