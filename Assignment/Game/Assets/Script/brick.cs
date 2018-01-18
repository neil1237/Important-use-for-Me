using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    public int speed;

    private Vector3 startPosition;
    
    public void Start()
    {
       speed = 3;

        startPosition = transform.position;
    }
    
    public void Update()
    {
        moveBrick();
    }

    void moveBrick()
    {
        transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * speed), transform.position.z);
        
    }
}

