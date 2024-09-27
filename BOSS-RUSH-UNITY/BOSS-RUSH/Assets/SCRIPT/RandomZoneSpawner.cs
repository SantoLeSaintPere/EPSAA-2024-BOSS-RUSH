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
    public int maxSize = 3;
    public int minSIze = 1;
    MeshRenderer meshRenderer;
    float  Xsize,Zsize;
    int rand;
    int counter;
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
        GameObject swordToSpawn = Instantiate(objectToSpawn[rand], new Vector3(x, 0, z) + transform.position, objectToSpawn[rand].transform.rotation, transform);
        int rand1 = Random.Range(minSIze,maxSize);
        swordToSpawn.transform.localScale = new Vector3(rand1, rand1, rand1);
        counter++;
        //yield return new WaitForSeconds(timeToSpawn);
        yield return null;
        StartCoroutine(SpawnEnemy());
    }
}
