using UnityEngine;

public class ParentFly : ZennyMonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float moveSpeed = 1f;
    [SerializeField] protected Vector3 direction = Vector3.right;
    void Update()
    {
        transform.parent.Translate(this.direction * this.moveSpeed * Time.deltaTime);
    }
}
