using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : ZennyMonoBehaviour
{
    private static DropManager instance;
    public static DropManager Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (DropManager.instance != null) Debug.Log("Only 1 Dropmanager allow to exist");
        DropManager.instance = this;
    }

    public virtual void Drop(List<DropRate> dropList)
    {
        Debug.Log(dropList[0].itemSO.itemName);
    }

}
