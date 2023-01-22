using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed = 25.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    private float topBound = 15;
    private float lowerBound = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep player in bound
        if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if (transform.position.x > xRange){
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        if (transform.position.z < lowerBound){
            transform.position = new Vector3(transform.position.x,transform.position.y,lowerBound);
        }
        if (transform.position.z > topBound){
            transform.position = new Vector3(transform.position.x,transform.position.y,topBound);
        }

        // Move
        horizontalInput =  Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // Launch a projectile form the player
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab,new Vector3(transform.position.x,1,transform.position.z+2),projectilePrefab.transform.rotation);
        }
    }
}
