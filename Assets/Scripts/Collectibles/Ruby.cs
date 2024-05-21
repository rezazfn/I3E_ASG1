/*
* Author: Reza
* Date: 12/05/2024
* Description: Destroys Collectible and updates all tracking UI text upon being collided/collected
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    // Allows player to change value of collectible in Unity Editor
    public int myScoreValue;
  
     // When the player collects the collectible 
    void Collected()
    {
        // Destroys collectible when player collects it
        Destroy(gameObject);
        // Adds the value of the collectible to total score collected so far
        ScoreTracker.scoreCount += myScoreValue;
        // Subtracts 1 from the total in game collectibles 
        RemainingTracker.remainingCount -= 1;
        // Adds 1 to the total amount of collectibles collected so far
        Congrats.collectedCount += 1;
    }

    // When the player collides with the collectible
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the Player tag
        if(collision.gameObject.tag == "Player")
        {
  
            // Upon collision, collectible gets collected
            Collected();
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