using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [HideInInspector]
    public float speed = 2.5f, timeToDestroy;
    [HideInInspector]
    public int damage;
    Vector3 dir;

    void Start()
    {
        dir = -Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        Destroy(gameObject, timeToDestroy);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealthManager>().TakeDamage(damage);
            Destroy(gameObject);

        }
    }
}
