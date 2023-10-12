using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 firingPoint;

    
    public GameObject shootingObj;

    [SerializeField]
    private float projectileSpeed;

    [SerializeField]
    private float maxProjectileDistance;

    private bool moves = false;
    void Start()
    {
        firingPoint = transform.position;
    }

   
    void Update()
    {
        if (moves)
        {
            MovingTheProjectile();
        }       
    }


    public void Movement()
    {       
        moves = true;
    }

    //Projectile's movement 
    void MovingTheProjectile()
    {
        if (Vector3.Distance(firingPoint, transform.position) > maxProjectileDistance)
        {
            ProjectilePooling.Instance.ReturnToPooling(this);
            moves = false;
        }
        else
        {
            transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        }        
    }
}
