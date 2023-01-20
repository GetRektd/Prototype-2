using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    GameManager gameManagerScript;
    
    void Start()
    {
        //** Create and Empty GameObject in your Hierarchy and name it GameManager and add the GameManager script to it for the line below to work **//
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //** Create a Tag for the player in the Hierarchy and apply the tag to the player **//
        //** Replace the word in quotations to the tag for your player **//
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            //** Pass an integer inside the method below to reduce your player's health **//
             gameManagerScript.UpdateLives(-1);
        }
        else
        {
            //** Pass an inter inside the method below to increase the player's score **//
            gameManagerScript.AddScore(+1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}