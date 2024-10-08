using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SistemaArma : MonoBehaviour
{
    public Transform barrel;
    public float fireRate;
    public GameObject bullet;
    public float fireTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleShooting();
    }
    private void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
    }
    private void Shoot()
    {
        fireTimer = Time.time + fireRate;
        Instantiate(bullet,barrel.position, barrel.rotation);
    }
    private bool canShoot()
    {
        return Time.time > fireTimer;
    }
}
