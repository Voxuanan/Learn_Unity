using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float leftBound = 30;
    private float rightBound = -30;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound){
            Destroy(gameObject); 
        } else if (transform.position.z < lowerBound){
              Destroy(gameObject);
        } else if (transform.position.x > leftBound){
              Destroy(gameObject);
        } else if (transform.position.x < rightBound){
              Destroy(gameObject);
        }
    }
}
