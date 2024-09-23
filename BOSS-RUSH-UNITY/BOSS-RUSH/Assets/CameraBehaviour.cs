using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float maxDistance = 10f;
    float currentDist;
    public float speed = 4.25f;

    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        currentDist = Vector3.Distance(transform.position, player.position);
        if(currentDist < maxDistance)
        {
            Vector3 playerPos = player.position;
            transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
        }

        else
        {
            transform.position = player.position;
        }
    }
}
