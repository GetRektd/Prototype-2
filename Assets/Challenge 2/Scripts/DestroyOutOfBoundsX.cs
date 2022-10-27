using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -5;
   float leftBound = -41;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        } 
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }

        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
