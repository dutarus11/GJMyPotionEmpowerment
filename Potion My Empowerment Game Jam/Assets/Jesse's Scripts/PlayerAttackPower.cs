using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttackPower : MonoBehaviour
{
    [SerializeField]
    Transform firingPoint;
    
    [SerializeField]
    GameObject projectilePrefab;
    
    [SerializeField]
    float firingSpeed;

    public static PlayerAttackPower Instance;

    private float lastShootingInstance = 0;
    void Awake()
    {
        Instance = GetComponent<PlayerAttackPower>();
    }

    
    void Update()
    {
        
    }

    public void Shoot()
    {
        if (lastShootingInstance + firingSpeed <= Time.time)
        {
            lastShootingInstance = Time.time;
            Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
        }
        
    }
}
