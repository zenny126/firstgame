using UnityEngine;

public class ShipShooting : ZennyMonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float shootDelay = 1f;
    [SerializeField] protected float shootTimer = 0f;
    [SerializeField] Transform spawnPos;


    void Update()
    {
        this.IsShooting();
        
    }
    private void FixedUpdate()
    {
        this.Shooting();
    }
    protected virtual void Shooting()
    {
        if (!this.isShooting) return;
        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootDelay > this.shootTimer) return;
        this.shootTimer = 0;
        
        Quaternion rotation = transform.parent.rotation;
        
        //Transform newBullet= Instantiate(this.bulletPrefab,spawnPos,rotation);
        Transform newBullet  = BulletSpawner.Instance.Spawn(BulletSpawner.bulletOne,spawnPos.position, rotation);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
        //Debug.Log("shooting");
    }
    protected virtual bool IsShooting()
    {
       this.isShooting=InputManager.Instance.OnFiring == 1;
        return this.isShooting;
    }
}