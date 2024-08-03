using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockZ : MonoBehaviour
{
    // Set this to true to lock the Z-axis movement
    public bool lockz = true;
    public int z = 40;

    void Update()
    {
        if (lockz)
        {
            // Lock the Z position
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }
    }
}

