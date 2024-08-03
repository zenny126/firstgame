using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockY : MonoBehaviour
{
    // Set this to true to lock the Z-axis movement
    public bool locky = true;
    public int y = 40;

    void Update()
    {
        if (locky)
        {
            // Lock the Z position
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
    }
}

