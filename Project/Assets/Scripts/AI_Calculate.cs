using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Calculate : MonoBehaviour
{
    Core core;
    new Rigidbody rigidbody;
    int speed = 1000;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if(core.is_shoot == true)
        {
            Vector3 calcu_Degreed = new Vector3(Mathf.Cos(core.Degree) * speed, Mathf.Sin(core.Degree) * speed);
            rigidbody.AddForce(calcu_Degreed);
            core.is_shoot = false;
            core.doubleclick = true;    
            Debug.Log("D");
        }
    }
}
