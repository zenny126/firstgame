using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : ZennyMonoBehaviour
{
    private static GameCtrl instance;
    
    public static GameCtrl Instance {  get { return instance; } }

     [SerializeField]   protected Camera mainCamera;

    public Camera MainCamera { get { return mainCamera; } }

    protected override void Awake()
    {
        base.Awake();
        if (GameCtrl.instance != null) Debug.Log("Only 1 GameCtrl allow to exits");
        GameCtrl.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCamera != null) return;
        this.mainCamera = GameCtrl.FindObjectOfType<Camera>();
        Debug.Log(transform.name + " :LoadCamera", gameObject);
    }
}
