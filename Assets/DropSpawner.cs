using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawner : Spawner
{
    private static DropSpawner instance;
    public static DropSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (DropSpawner.instance != null) Debug.Log("Only 1 DropSpawner allow to exist");
        DropSpawner.instance = this;
    }
    public virtual void Drop(List<DropRate> dropList,Vector3 pos, Quaternion rot)
    {
       ItemCode itemCode = dropList[0].itemSO.itemCode;
        Transform itemDrop= this.Spawn(itemCode.ToString(), pos, rot);
        itemDrop.gameObject.SetActive(true);
    }
}
