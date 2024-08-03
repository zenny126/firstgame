using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float speed = 0.001f;
    private CameraBoundaries cameraBoundaries;

    private void Start()
    {
        cameraBoundaries = FindObjectOfType<CameraBoundaries>();
    }

    private void FixedUpdate()
    {
        GetTargetPos();
        LookAtTarget();
        Moving();
    }

    protected virtual void GetTargetPos()
    {
        targetPosition = InputManager.Instance.MouseWorldPosition;
        targetPosition.z = 0;
    }

    protected virtual void LookAtTarget()
    {
        Vector3 diff = targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);
    }

    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPosition, speed);

        // Clamp the new position within the camera boundaries
        newPos.x = Mathf.Clamp(newPos.x, cameraBoundaries.MinBounds.x, cameraBoundaries.MaxBounds.x);
        newPos.y = Mathf.Clamp(newPos.y, cameraBoundaries.MinBounds.y, cameraBoundaries.MaxBounds.y);

        transform.parent.position = newPos;
    }
}
