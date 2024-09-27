using System.Collections;
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
    public float fireRate;

    [Header("Muzzle")]
    public GameObject muzleEffect;
    public float timeToHideMuzzleEffect;
    // Start is called before the first frame update
    void Start()
    {
        maxAmmo = ammoIMG.Length;
        currentAmmo = maxAmmo;
        DisableAimingPoint();
        muzleEffect.SetActive(false);
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
        StartCoroutine(ShowMuzzleEffect());
    }

    IEnumerator ShowMuzzleEffect()
    {
        muzleEffect.SetActive(true);
        yield return new WaitForSeconds(timeToHideMuzzleEffect);
        muzleEffect.SetActive(false);
        StopAllCoroutines();
    }
}
