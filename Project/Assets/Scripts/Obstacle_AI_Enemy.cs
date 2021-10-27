using UnityEngine;
using UnityEngine.AI;

public class Obstacle_AI_Enemy : MonoBehaviour
{
    public GameObject pos3;
    public GameObject pos4;
    NavMeshAgent nav;
    AI aI;
    Core core;
    private void Start() 
    {
        core = gameObject.GetComponent<Core>();
        nav = GetComponent<NavMeshAgent>();
        aI = gameObject.GetComponent<AI>();
        transform.position = pos3.transform.position;
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.name == "Obstacle_target_3")
        {
            nav.SetDestination(pos4.transform.position);
        }
        if(other.name == "Obstacle_target_4")
        {
            nav.SetDestination(pos3.transform.position);
        }
        if(other.name == "EmemyAI")
        {
            aI.moved = true;
            core.is_touch_Obstacle = true;
        }    
    }
}