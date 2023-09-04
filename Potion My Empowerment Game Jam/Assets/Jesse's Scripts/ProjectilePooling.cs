using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePooling : MonoBehaviour
{
    [SerializeField]
    float poolLength;
     

    
    public GameObject projectilePrefab;

    private List<Projectile> projectilesInPool;

    public static ProjectilePooling Instance;

    private void Awake()
    {
        Instance = GetComponent<ProjectilePooling>();
    }

    void Start()
    {        
        PoolInitialization();       
    }

    //void Update()
    //{
    //    PoolInitialization();
    //}
    public Projectile Instantiate(Vector3 pos, Quaternion rot)
    {
        Projectile _projectile = projectilesInPool[0];
        _projectile.transform.position = pos;
        _projectile.transform.rotation = rot;
        projectilesInPool.Remove(_projectile);
        
        return _projectile;
    }

    public void ReturnToPooling(Projectile _projectile)
    {
        _projectile.transform.position = transform.position;
        projectilesInPool.Add(_projectile);
    }
    void PoolInitialization()
    {
        projectilesInPool= new List<Projectile>();
       
        for (int i = 0; i < poolLength; i++)
        {
           
            GameObject _projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
            projectilesInPool.Add(_projectile.GetComponent<Projectile>());
        }
        
    }

   
}
