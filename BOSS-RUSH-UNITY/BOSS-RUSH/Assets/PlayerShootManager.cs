using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootManager : MonoBehaviour
{
    public GameObject aimingPoint;
    public Transform shootPoint;

    [Header("AMMO")]
    public GameObject[] ammoIMG; 
    int maxAmmo;
    public int currentAmmo;

    [Header("SHOOT")]
    public float timeToShoot;

    [Header("BULLET")]
    public GameObject bullet;
    public float timerToDestroyBullet;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        maxAmmo = ammoIMG.Length;
        currentAmmo = maxAmmo;
        DisableAimingPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableAimingPoint()
    {
        aimingPoint.SetActive(true);
    }

    public void DisableAimingPoint()
    {
        aimingPoint.SetActive(false);
    }

    public void RegainShoot()
    {
        ammoIMG[currentAmmo].SetActive(true);
        currentAmmo++;
    }

    public void Shoot()
    {
        ammoIMG[currentAmmo-1].SetActive(false);
        currentAmmo--;
        GameObject bulletInst = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        bulletInst.GetComponent<Bullet>().speed = bulletSpeed;
        bulletInst.GetComponent<Bullet>().timeToDestroy = timerToDestroyBullet;
    }
}
