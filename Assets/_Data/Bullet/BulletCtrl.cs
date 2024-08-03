using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : ZennyMonoBehaviour
{
    [SerializeReference] DamageSender damageSender;
    public DamageSender DamageSender { get => damageSender; }

    [SerializeReference] BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn { get => bulletDespawn; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDamageSender();
        this.LoadBulletDespawn();
    }

    protected virtual void LoadDamageSender()
    {
        if (damageSender != null) return;
        this.damageSender= transform.GetComponentInChildren<DamageSender>();
        Debug.Log(transform.name+ ": LoadDamageSender", gameObject);
        
    }
    protected virtual void LoadBulletDespawn()
    {
        if (bulletDespawn != null) return;
        this.bulletDespawn = transform.GetComponentInChildren<BulletDespawn>();
        Debug.Log(transform.name+ ": LoadBulletDespawn", gameObject);
        
    }

}
