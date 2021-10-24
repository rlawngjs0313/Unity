using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Calculate : MonoBehaviour
{
    Core core;
    AI ai;
    new Rigidbody rigidbody;
    public float Degree = 45.0f;
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
        if(core.dc_cal == 0)
       {
            core.dc_cal ++;
            Vector3 calcu_Degreed = new Vector3(Mathf.Cos(Degree) * speed, Mathf.Sin(Degree) * speed);
            rigidbody.AddForce(calcu_Degreed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Plane")
        {
            Object.Destroy(this.gameObject);
            core.is_fail_AI = true;
        }
        if(other.tag == "Player")
        {
            Object.Destroy(this.gameObject);
            core.is_hit_AI = true;
        }
    }
}
