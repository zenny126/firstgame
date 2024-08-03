using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : ZennyMonoBehaviour
{
    [SerializeField] protected int damage = 1;
    
    public virtual void Send(Transform obj)
    {
        DamageReceiver damageReceiver= obj.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);

    }

    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
        this.CreatImpactFX();

    }
    protected virtual void CreatImpactFX()
    {
        string fxName = this.GetImpactFX();
        Vector3 hitPos = transform.position;
        Quaternion hitRos = transform.rotation;
        Transform fxImpact = FXSpawner.Instance.Spawn(fxName, hitPos, hitRos);
        fxImpact.gameObject.SetActive(true);
    }
    protected virtual string GetImpactFX()
    {
        return FXSpawner.impact1;
    }
}
