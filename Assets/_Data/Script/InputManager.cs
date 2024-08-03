using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;

    public static InputManager Instance { get => instance; }
    [SerializeField] protected Vector3 mouseWorldPosition;
    public Vector3 MouseWorldPosition { get => mouseWorldPosition; }
    [SerializeField] protected float onFiring;
    public float OnFiring { get => onFiring; }
    // Start is called before the first frame update
    private void Awake()

    {
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager allow to exits");
        InputManager.instance = this;
    }
    private void FixedUpdate()
    {
        this.GetMousePosition();
        this.GetMouseDown();


    }
    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
    protected virtual void GetMousePosition()
    {
        this.mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
