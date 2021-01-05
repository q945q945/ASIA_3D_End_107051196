using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    [Header("移動速度"), Range(0, 50)]
    public float speed = 3;
    [Header("停止距離"), Range(0, 50)]
    public float stopDistance = 2.5f;

    private Transform player;
    private NavMeshAgent nav;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();

        player = GameObject.Find("robot").transform;

        nav.speed = speed;
        nav.stoppingDistance = stopDistance;

    }

    private void Update()
    {
        Track();
    }
    private void Track()
    {
        nav.SetDestination(player.position);
    }
}
