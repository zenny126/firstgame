using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAbstract : ZennyMonoBehaviour
{
    [SerializeField] protected BulletCtrl bulletCtrl;
    public BulletCtrl BulletCtrl { get => bulletCtrl; } 

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDamageReceiver();

    }

    protected virtual void LoadDamageReceiver()
    {
        if (this.bulletCtrl != null) return;
        this.bulletCtrl = transform.parent.GetComponent<BulletCtrl>();
        Debug.Log(transform.name + ": LoadDamageReceiver", gameObject);
    }
}
