using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttackPower : MonoBehaviour
{
    [SerializeField]
    Transform firingPoint;
    
       
    [SerializeField]
    float firingSpeed;

    public static PlayerAttackPower Instance;

    private float lastShootingInstance = 0;
    void Awake()
    {
        Instance = GetComponent<PlayerAttackPower>();
    }

    public void Shoot()
    {
        if (lastShootingInstance + firingSpeed <= Time.time)
        {
            Projectile _projectile = ProjectilePooling.Instance.Instantiate(firingPoint.position, firingPoint.rotation);
            _projectile.Movement();
            lastShootingInstance = Time.time;
        }

    }
  
}
