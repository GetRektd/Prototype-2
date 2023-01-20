using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float xRange = 15;
    public float speed = 10.0f;
    public float verticalInput;
    public float yRange = 10;


    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //keep the player in bounds
        if (transform.position.x < -xRange)
        { 
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if(transform.position.z < -4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4);
        }
        if(transform.position.z > 13)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 13);
        }
        
    }
}