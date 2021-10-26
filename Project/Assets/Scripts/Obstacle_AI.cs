using UnityEngine;
using UnityEngine.AI;

public class Obstacle_AI : MonoBehaviour
{
    Core core;
    NavMeshAgent nav;
    int test = 0;
    private void Start() 
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        nav = GetComponent<NavMeshAgent>();
        test = Random.Range(-100, 100);
        transform.position = new Vector3(test, 1, 0);
    }
    private void Update() 
    {
        move();
    }
    void move()
    {
        if(test >= 0)
            Debug.Log(test);
        if(transform.position.x > -12)            
        {
            if(transform.position.x < 12)
            {
                Object.Destroy(this);
                transform.position = new Vector3(Random.Range(-100, 100), 1, 0);
            }
        }
    }
}