using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    
    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.x <= -6)
        {
            direction *= -1;
        }
        if (transform.position.x >= 6)
        {
            direction *= -1;
        }
    }

   
}
