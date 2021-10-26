using UnityEngine;
using UnityEngine.AI;

public class Obstacle_AI : MonoBehaviour
{
    int Random_num = 0;
    NavMeshAgent nav;
    private void Start() 
    {
        nav = GetComponent<NavMeshAgent>();
        Random_num = Random.Range(-20, 20);
        transform.position = new Vector3(Random.Range(-100, 100), 1, 0);
    }
    private void Update() 
    {
        spawn();
    }
    void spawn()
    {
        if(transform.position.x <= -11)
            nav.SetDestination(GameObject.Find("Player").transform.position - new Vector3(Random_num, 0, 0));
        if(transform.position.x >= 11)
            nav.SetDestination(GameObject.Find("EnemyAI").transform.position - new Vector3(Random_num, 0, 0));
    }
}