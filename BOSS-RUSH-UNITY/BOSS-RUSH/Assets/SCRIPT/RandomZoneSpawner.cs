using System.Collections;
using UnityEngine;

public class RandomZoneSpawner : MonoBehaviour
{
    [Header("ONLY WITH PRO BUILDER")]
    public GameObject[] objectToSpawn;
    public int objectNumber;
    [Header("TIME TO SPAWN HIDE IN SCRIPT")]
    //public float timeToSpawn = 4;
    [Header("RANDOM SIZE")]
    public float maxSize = 3;
    public float minSIze = 1;
    MeshRenderer meshRenderer;
    float  Xsize,Zsize;
    int rand;
    int counter;

    public float rotZ = 25f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        Xsize = (meshRenderer.bounds.size.x /2) ;
        Zsize = (meshRenderer.bounds.size.z /2);
        counter = 0;
        StartCoroutine(SpawnEnemy());
    }

    void Update()
    {
        if(counter == objectNumber)
        {
            StopAllCoroutines();
        }
    }

    IEnumerator SpawnEnemy()
    {
        rand = Random.Range(0,objectToSpawn.Length);
        float x = Random.Range(Xsize, -Xsize);
        float z = Random.Range(Zsize, -Zsize);
        float randRot = Random.Range(rotZ, -rotZ);
        GameObject swordToSpawn = Instantiate(objectToSpawn[rand], new Vector3(x, 0, z) + transform.position, Quaternion.Euler(0,0,randRot), transform);
        float randSize = Random.Range(minSIze,maxSize);
        swordToSpawn.transform.localScale = new Vector3(randSize, randSize, randSize);
        counter++;
        //yield return new WaitForSeconds(timeToSpawn);
        yield return null;
        StartCoroutine(SpawnEnemy());
    }
}
