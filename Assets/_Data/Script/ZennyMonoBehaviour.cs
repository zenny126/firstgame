using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZennyMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset() {
        this.LoadComponents();
        this.ResetValue();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void Start()
    {

    }
    protected virtual void LoadComponents()
    {
       // For override
    }
    protected virtual void ResetValue()
    {
        //For override
    }
    protected virtual void OnEnable()
    {
        // for override
    }
}
