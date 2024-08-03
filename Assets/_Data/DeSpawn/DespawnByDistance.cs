using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    // Start is called before the first frame update
    [SerializeField] protected float disLimit = 70f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Camera mainCam;

    protected override void LoadComponents()
    {
        LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam= Transform.FindObjectOfType<Camera>(); 

    }
    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.transform.position);
        if (this.distance > this.disLimit) return true;
        return false;
    }
}
