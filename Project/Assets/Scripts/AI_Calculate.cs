using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Calculate : MonoBehaviour
{
    Core core;
    new Rigidbody rigidbody;
    public float Degree = 45.0f;
    int speed = 1000;
    int doubleclick = 0;
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
        if(doubleclick == 0)
       {
            doubleclick ++;
            Vector3 calcu_Degreed = new Vector3(Mathf.Cos(Degree) * speed, Mathf.Sin(Degree) * speed);
            rigidbody.AddForce(calcu_Degreed);
            core.is_shoot = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Plane")
        {
            Object.Destroy(this.gameObject);
        }
    }
}
