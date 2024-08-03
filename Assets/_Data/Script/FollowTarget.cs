using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowTarget : ZennyMonoBehaviour
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float speed = 1.0f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTarget();
    }
    private void FixedUpdate()
    {
        this.Following();
    }
    protected virtual void LoadTarget()
    {
        if(this.target == null)
        {
            //this.target= 
        }
    }
    protected virtual void Following()
    {
        if (this.target == null) return;
        transform.position = Vector2.Lerp(transform.position, this.target.position,Time.fixedDeltaTime* this.speed);
    }
}
