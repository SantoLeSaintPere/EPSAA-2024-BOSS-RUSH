using System.Collections;
using UnityEngine;

public class PlayerShootManager : MonoBehaviour
{
    public GameObject aimingPoint;
    public GameObject damageZoneIndicator;

    [Header("AMMO")]
    public GameObject[] ammoIMG; 
    int maxAmmo;
    public int currentAmmo;

    [Header("SHOOT")]
    public float fireRate;

    [Header("Muzzle")]
    public GameObject muzleEffect;
    public float timeToHideMuzzleEffect;

    [Header("SHOOT STUFF")]
    public int shootDamage;
    public float shootRange;
    public float yOffset;
    public LayerMask enemyMask;


    Transform target;
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
        damageZoneIndicator.SetActive(false);
    }

    public void DisableAimingPoint()
    {
        aimingPoint.SetActive(false);
        damageZoneIndicator.SetActive(true);

        if (target != null)
        {
            target.GetComponent<BossTargetterManager>().DisableTargetter();
            target = null;
        }
    }

    public void RegainShoot()
    {
        if(currentAmmo <  maxAmmo)
        {
            ammoIMG[currentAmmo].SetActive(true);
            currentAmmo++;
        }
    }

    public void CheckTarget()
    {
        RaycastHit newHit;
        if (Physics.Raycast(transform.position + new Vector3(0, yOffset, 0), transform.forward, out newHit, shootRange, enemyMask))
        {
            target = newHit.transform;
            target.GetComponent<BossTargetterManager>().EnableTargetter();
        }

        else
        {
            if (target != null)
            {
                target.GetComponent<BossTargetterManager>().DisableTargetter();
                target = null;
            }
        }
    }
    public void Shoot()
    {

        bool canShoot =  target != null && target.GetComponent<BossHealthManager>() != null && !target.GetComponent<BossHealthManager>().healthLocked && !target.GetComponent<BossHealthManager>().isDead && currentAmmo != 0;

        if (canShoot)
        {
            target.GetComponent<BossHealthManager>().TakeDamage(shootDamage);
        }

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

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position + new Vector3(0, yOffset, 0), transform.forward * shootRange);
    }
}
