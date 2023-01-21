using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 45;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    private float timestamp = 0f;
    public int id;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"+id);
        forwardInput = Input.GetAxis("Vertical"+id);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey) && Time.time >= timestamp)
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
            timestamp = Time.time + 0.5f;
        }

    }
}
