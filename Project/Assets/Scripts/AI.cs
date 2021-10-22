using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    Core core;
    NavMeshAgent nav;
    new Rigidbody rigidbody;
    bool moved = false;
    bool moving = false;
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
        shoot();
        move();
    }
    void move()
    {
        if(core.ismyturn == false)
        {
            nav.SetDestination(core.pos2);
            if(nav.velocity.magnitude > 0)
            {
                moving = true;
            }
            if(moving == true)
            {
                if(nav.velocity.magnitude == 0)
                {
                    moved = true;
                }
            }
        }
    }
    void shoot()
    {
        if(moved == true)
        {
            if(core.doubleclick == false)
            {
                core.is_shoot = true;
                Instantiate(bullet, shoots);
            }        
        }
    }
}
