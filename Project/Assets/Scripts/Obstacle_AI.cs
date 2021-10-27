using UnityEngine;
using UnityEngine.AI;

public class Obstacle_AI : MonoBehaviour
{
    public GameObject pos1;
    public GameObject pos2;
    NavMeshAgent nav;
    Core core;
    private void Start() 
    {
        nav = GetComponent<NavMeshAgent>();
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        transform.position = pos1.transform.position;
    }
    private void Update() 
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Obstacle_target_1")
        {
            nav.SetDestination(pos2.transform.position);
        }
        if(other.name == "Obstacle_target_2")
        {
            nav.SetDestination(pos1.transform.position);
        }
        if(other.name == "Player")
        {
            core.timeover = true;
            core.Degree = Random.Range(44.2f, 45.55f);
        }
    }
}