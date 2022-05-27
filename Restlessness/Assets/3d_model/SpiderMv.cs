using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderMv : MonoBehaviour
{
    
    private NavMeshAgent spider;

    public GameObject Player;

    public float SpiderDistanceRun = 4.0f;
    void Start()
    {
        spider = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < SpiderDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            spider.SetDestination(newPos);
        }
    }
}
