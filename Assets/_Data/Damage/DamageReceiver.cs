using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class DamageReceiver : ZennyMonoBehaviour
{
    [SerializeField] protected int hp = 1;
    [SerializeField] protected int hpMax = 5;
    [SerializeField] protected bool isDead= false;
    [SerializeField ]protected SphereCollider sphereCollider;
    protected override void OnEnable()
    {
  
        this.Reborn();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }
    protected virtual void LoadCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        this.sphereCollider.isTrigger = true;
        this.sphereCollider.radius = 0.5f;
        Debug.Log(transform.name + ": LoadCollider", gameObject);

    }
    public virtual void Reborn()
    {
        this.hp = this.hpMax;
        this.isDead = false;
    }
    public virtual void Add(int add)
    {
        if (this.isDead) return;
        this.hp += add;
        if(this.hp>this.hpMax) this.hp= this.hpMax;
    }
    public virtual void Deduct(int deduct)
    {
        this.hp -= deduct;
        if(this.hp<0) this.hp= 0;
        this.CheckIsDead();
    }
    protected virtual bool IsDead()
    {
        return this.hp <= 0;
    }
    protected virtual void CheckIsDead()
    {
        if(!this.IsDead()) return;
        this.isDead= true;
        this.OnDead();
    }
    protected virtual void OnDead()
    {
        //For Override
    }
}
