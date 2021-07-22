using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    public float minX, maxX;
    
    void Start()
    {
        minX = 37f;
        maxX = 440f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = gameObject.transform.position;

        if (temp.x > maxX)
            temp.x = maxX;

        if (temp.x < minX)
            temp.x = minX;

        gameObject.transform.position = temp;

    }
}
