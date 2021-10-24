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
    public GameObject bullet;
    public Transform trans;
    bool moved = false;
    int doubleclick = 0;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        rigidbody = GetComponent<Rigidbody>();
        nav = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        move();
        Shoot();
    }
    void move()
    {
        if(core.ismyturn == false)
        {
            nav.SetDestination(core.pos2);
            if(nav.remainingDistance == 0)
                moved = true;
        }
    }
    void Shoot()
    {
        if(moved == true)
        {
            if(doubleclick == 0)
            {
                doubleclick ++;
                Instantiate(bullet, trans);
            }
        }
    }
}
