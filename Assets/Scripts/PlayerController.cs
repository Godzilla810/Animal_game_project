using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 20;
    private float zRange = 15;
    private float speed = 15.0f;
    public Transform projectileSpawnPoint;
    
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        // Keep the player in bounds
        if (transform.position.x < -xRange ){
            transform.position = new Vector3(-xRange ,transform.position.y ,transform.position.z);
        }
        if (transform.position.x > xRange ){
            transform.position = new Vector3(xRange ,transform.position.y ,transform.position.z);
        }
        if (transform.position.z < 0 ){
            transform.position = new Vector3(transform.position.x ,transform.position.y ,0);
        }
        if (transform.position.z > zRange ){
            transform.position = new Vector3(transform.position.x ,transform.position.y ,zRange);
        }
        
        //Launch food
        if (Input.GetKeyDown(KeyCode.Space)){
            //Launch a projectile from the player
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectilePrefab.transform.rotation);
            //Instantiate:create copy;(object,position,rotation)
        }
    }
}
