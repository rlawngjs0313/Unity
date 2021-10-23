using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    Core core;
    NavMeshAgent nav;
    AI_Calculate ai;
    new Rigidbody rigidbody;
    int doubleclick = 0;
    bool moved = false;
    public GameObject bullet;
    public Transform shoots;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        rigidbody = GetComponent<Rigidbody>();
        nav = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        move();
        shoot();
    }
    void move()
    {
        if(core.ismyturn == false)
        {
            nav.SetDestination(core.pos2);
            if(nav.remainingDistance == 0)
            {
                moved = true;
            }
        }
    }
    void shoot()
    {
        if(moved == true)
        {
            if(doubleclick == 0)
            {
                doubleclick ++;
                Instantiate(bullet, shoots);
            }
        }
    }
}
